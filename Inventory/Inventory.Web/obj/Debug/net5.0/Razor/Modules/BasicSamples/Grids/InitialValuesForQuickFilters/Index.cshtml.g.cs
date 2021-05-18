#pragma checksum "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\InitialValuesForQuickFilters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9c1ff6d36083bf9a034bcbe8fe3f9eca296323"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_InitialValuesForQuickFilters_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/InitialValuesForQuickFilters/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9c1ff6d36083bf9a034bcbe8fe3f9eca296323", @"/Modules/BasicSamples/Grids/InitialValuesForQuickFilters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709696f6457805a38702a962aec1174e381c722d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_InitialValuesForQuickFilters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\InitialValuesForQuickFilters\Index.cshtml"
  
    ViewData["Title"] = "Initial Values for Quick Filters";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\InitialValuesForQuickFilters\Index.cshtml"
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
    <p>
        Sometimes you might want to set some initial values for quick filters on page load.
        Here we do it for ""Order Date"", ""Shipping State"" and ""Ship Via Company"".
    </p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
#nullable restore
#line 17 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\InitialValuesForQuickFilters\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n        ");
#nullable restore
#line 18 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Grids\InitialValuesForQuickFilters\Index.cshtml"
   Write(Html.AppSourceFile("InitialValuesForQuickFilters.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new Inventory.BasicSamples.InitialValuesForQuickFilters($('#GridDiv'), {}).init();

        Q.initFullHeightGridPage($('#GridDiv'));
    });
</script>");
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