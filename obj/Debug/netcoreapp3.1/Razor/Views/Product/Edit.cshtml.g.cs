#pragma checksum "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5cccf44765a5a6c3bea6900fa8e338fec0701c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
#line 1 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/_ViewImports.cshtml"
using Giohang2601;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/_ViewImports.cshtml"
using Giohang2601.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5cccf44765a5a6c3bea6900fa8e338fec0701c5", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f22f13b4bf04f1c45a391847483f61fd2c44769", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Giohang2601.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <div>\n            <label>Product Id</label>\n            ");
#nullable restore
#line 12 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
       Write(Html.EditorFor(p=>p.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div>\n            <label>ProductName</label>\n            ");
#nullable restore
#line 16 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
       Write(Html.EditorFor(p=>p.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div>\n            <label>Price</label>\n            ");
#nullable restore
#line 20 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
       Write(Html.EditorFor(p=>p.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div>\n            <label>Photo</label>\n            ");
#nullable restore
#line 24 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
       Write(Html.EditorFor(p=>p.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>   \n    <div>\n        <input type=\"submit\" value=\"Update\" class=\"btn btn-success\"/>\n    </div>\n    <h2>");
#nullable restore
#line 30 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 31 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
Write(Html.ActionLink("Back to List","Index"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Edit.cshtml"
                                            
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Giohang2601.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
