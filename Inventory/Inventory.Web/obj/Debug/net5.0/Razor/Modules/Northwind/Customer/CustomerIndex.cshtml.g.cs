#pragma checksum "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Customer\CustomerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db96c6ebc436d10e8a7dd695f2c40488bbc90625"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Northwind_Customer_CustomerIndex), @"mvc.1.0.view", @"/Modules/Northwind/Customer/CustomerIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db96c6ebc436d10e8a7dd695f2c40488bbc90625", @"/Modules/Northwind/Customer/CustomerIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709696f6457805a38702a962aec1174e381c722d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Northwind_Customer_CustomerIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Customer\CustomerIndex.cshtml"
  
    ViewData["Title"] = Localizer.Get("Db.Northwind.Customer.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Customer\CustomerIndex.cshtml"
Write(Html.Script("dynamic://Lookup.Northwind.CustomerCountry"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Customer\CustomerIndex.cshtml"
Write(Html.Script("dynamic://Lookup.Northwind.CustomerCity"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Customer\CustomerIndex.cshtml"
Write(Html.Script("dynamic://Lookup.Northwind.Employee"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n<script>var CKEDITOR_BASEPATH = \'");
#nullable restore
#line 12 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Customer\CustomerIndex.cshtml"
                            Write(ContentHashCache.ResolvePath(Context.Request.PathBase, "~/Scripts/ckeditor/"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';</script>\r\n");
#nullable restore
#line 13 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Customer\CustomerIndex.cshtml"
Write(Html.ScriptBundle("CKEditor"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new Inventory.Northwind.CustomerGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IContentHashCache ContentHashCache { get; private set; }
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
