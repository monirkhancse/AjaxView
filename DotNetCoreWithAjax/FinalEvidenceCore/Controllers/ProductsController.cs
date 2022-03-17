using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalEvidenceCore.Models;
using Microsoft.AspNetCore.Hosting;
using FinalEvidenceCore.ViewModels;
using System.IO;

namespace FinalEvidenceCore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CustomerInfoDbContext _context;
        private readonly IHostingEnvironment _hostEnvironment;

        public ProductsController(CustomerInfoDbContext context, IHostingEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Products
        public IActionResult Index()
        {
            List<VM_Product_List> list = _context.Products.Select(t => new VM_Product_List
            {
                ProductId = t.ProductId,
                ProductName = t.ProductName,
                PurchasePrice = t.PurchasePrice,
                SalesPrice = t.SalesPrice,
                OrderQuantity = t.OrderQuantity,
                ExpireDate = t.ExpireDate,
                ImageName = t.ImageName,
                ImageUrl = t.ImageUrl
            }).ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> AddOrEdit(VM_Product_Create vmc)
        {
            var result = false;
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(vmc.ImageFile.FileName);
            string extension = Path.GetExtension(vmc.ImageFile.FileName);
            string fileWithExtension = fileName + extension;
            Product product = new Product();
            product.ProductName = vmc.ProductName;
            product.PurchasePrice = vmc.PurchasePrice;
            product.SalesPrice = vmc.SalesPrice;
            product.OrderQuantity = vmc.OrderQuantity;
            product.ExpireDate = vmc.ExpireDate;
            product.ImageName = fileWithExtension;
            product.ImageUrl = wwwRootPath + "/VM_Images/" + fileName + extension;
            string serverPath = Path.Combine(wwwRootPath + "/VM_Images/" + fileName + extension);
            using (var fileStream = new FileStream(serverPath, FileMode.Create))
            {
                await vmc.ImageFile.CopyToAsync(fileStream);
            }
            if (ModelState.IsValid)
            {
                if (vmc.ProductId == 0)
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    result = true;
                }
                else
                {
                    product.ProductId = vmc.ProductId;
                    _context.Entry(product).State = EntityState.Modified;
                    _context.SaveChanges();
                    result = true;
                }
            }
            if (result)
            {
                return RedirectToAction("Index", "Products");
            }
            else
            {
                if (vmc.ProductId == 0)
                {
                    return View("Create");
                }
                else
                {
                    return View("Edit");
                }
            }
        }
        public IActionResult Edit(int id)
        {
            Product product = _context.Products.SingleOrDefault(t => t.ProductId == id);
            VM_Product_Create vmc = new VM_Product_Create();
            vmc.ProductId = product.ProductId;
            vmc.ProductName = product.ProductName;
            vmc.PurchasePrice = product.PurchasePrice;
            vmc.SalesPrice = product.SalesPrice;
            vmc.OrderQuantity = product.OrderQuantity;
            vmc.ExpireDate = product.ExpireDate;
            vmc.ImageUrl = product.ImageUrl;
            vmc.ImageName = product.ImageName;
            return View(vmc);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: RoomDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
