#pragma checksum "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e867ab3fb274cdb3341e5f91a848a3bde2bb1943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_ViewWithoutID_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/ViewWithoutID/Index.cshtml")]
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
#line 1 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\_ViewImports.cshtml"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e867ab3fb274cdb3341e5f91a848a3bde2bb1943", @"/Modules/BasicSamples/Grids/ViewWithoutID/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709696f6457805a38702a962aec1174e381c722d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_ViewWithoutID_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
  
    ViewData["Title"] = "View Without ID";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small></small></h1>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>One of the frequently asked questions about Serenity is how to work views, and especially with ones without an ID column.</p>
    <p>Actually this is a requirement of SlickGrid, as it needs a unique ID for items.</p>
    <p>It could be possible to use an expression field (doesn't have to be in view) by concatting view fields to get a composite ID.</p>
    <p>Anyway in this sample we are using a view from Northwind (Sales By Category) that doesn't have an ID, and we are not using a composite key.</p>
    <p>See ");
#nullable restore
#line 15 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
      Write(Html.AppSourceFile("ViewWithoutIDGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" for how to set a fake autoincrementing ID client side by intercepting OnViewProcessData method.</p>\r\n    \r\n    <p style=\"text-align: right;\"><b>Source Files:</b> ");
#nullable restore
#line 17 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
                                                  Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
                                                                                       Write(Html.AppSourceFile("ViewWithoutIDGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new Inventory.BasicSamples.ViewWithoutIDGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591