#pragma checksum "C:\Users\monir\source\repos\FinalEvidenceCore\FinalEvidenceCore\Views\Suppliers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bae45427250082642f708c097c69c34854f3d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suppliers_Index), @"mvc.1.0.view", @"/Views/Suppliers/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\monir\source\repos\FinalEvidenceCore\FinalEvidenceCore\Views\_ViewImports.cshtml"
using FinalEvidenceCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\monir\source\repos\FinalEvidenceCore\FinalEvidenceCore\Views\_ViewImports.cshtml"
using FinalEvidenceCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bae45427250082642f708c097c69c34854f3d6f", @"/Views/Suppliers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94fd2cc2121782d397ac7cb4ab1a7b1b7c80577", @"/Views/_ViewImports.cshtml")]
    public class Views_Suppliers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalEvidenceCore.Models.Supplier>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\monir\source\repos\FinalEvidenceCore\FinalEvidenceCore\Views\Suppliers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 9 "C:\Users\monir\source\repos\FinalEvidenceCore\FinalEvidenceCore\Views\Suppliers\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""form-modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\monir\source\repos\FinalEvidenceCore\FinalEvidenceCore\Views\Suppliers\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalEvidenceCore.Models.Supplier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
