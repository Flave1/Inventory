#pragma checksum "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Shipper\ShipperIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4963b21e0b029db9bf69a8481ab8db78b04f5fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Northwind_Shipper_ShipperIndex), @"mvc.1.0.view", @"/Modules/Northwind/Shipper/ShipperIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4963b21e0b029db9bf69a8481ab8db78b04f5fe", @"/Modules/Northwind/Shipper/ShipperIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709696f6457805a38702a962aec1174e381c722d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Northwind_Shipper_ShipperIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Shipper\ShipperIndex.cshtml"
  
    ViewData["Title"] = Localizer.Get("Db.Northwind.Shipper.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new Inventory.Northwind.ShipperGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
