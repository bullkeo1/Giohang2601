#pragma checksum "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63725634d7cc2b3e41aaaa46130c8121d4b721c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63725634d7cc2b3e41aaaa46130c8121d4b721c2", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f22f13b4bf04f1c45a391847483f61fd2c44769", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Giohang2601.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
Write(Html.ActionLink("Create","Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table\">\n    <tr>\n        <th>ProductId</th>\n        <th>Product Name</th>\n        <th>Price</th>\n        <th>Photo</th>\n        <th>Action</th>\n    </tr>\n");
#nullable restore
#line 16 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 19 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
       Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 20 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 21 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td><img src=\"~images/\"");
#nullable restore
#line 22 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
                          Write(item.Photo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" width=\"70\"/></td>\n        <td>\n            ");
#nullable restore
#line 24 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
       Write(Html.ActionLink("Edit","Edit",new{@class="btn btn-success"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 25 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
       Write(Html.ActionLink("Delete","Delete",new{@class="btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 26 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
       Write(Html.ActionLink("Add to Cart","Buy","Order",new{id=item.ProductId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n");
#nullable restore
#line 29 "/Users/bullkeo/RiderProjects/HaTapLam/NetCore/Giohang2601/Views/Product/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Giohang2601.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591