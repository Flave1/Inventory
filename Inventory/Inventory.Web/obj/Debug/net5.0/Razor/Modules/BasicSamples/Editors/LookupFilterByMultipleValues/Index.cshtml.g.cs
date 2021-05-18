#pragma checksum "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a87ee38c5d59a5dadab244c0861ca3f2f398ca49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Editors_LookupFilterByMultipleValues_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Editors/LookupFilterByMultipleValues/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87ee38c5d59a5dadab244c0861ca3f2f398ca49", @"/Modules/BasicSamples/Editors/LookupFilterByMultipleValues/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709696f6457805a38702a962aec1174e381c722d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Editors_LookupFilterByMultipleValues_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
  
    ViewData["Title"] = "Lookup Filtering By Multiple Values (IN)";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
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
        This sample demonstrates how to filter a lookup client side by multiple values.
    </p>
    <p>
        You can normally use LookupField and LookupValue to filter a lookup editor by single value,
        but to use multiple values with IN(...) filtering you need to define a custom editor.
    </p>
    <p>
        Here we use a subclass of LookupEditor to show only Produce and Seafood in category
        editor of product dialog. Creating custom editors in Serenity is actually simple. 
        See ProduceSeafoodCategoyEditor.ts.
    </p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
#nullable restore
#line 25 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n        ");
#nullable restore
#line 26 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("LookupFilterByMultipleForm.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("LookupFilterByMultipleDialog.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("LookupFilterByMultipleGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\BasicSamples\Editors\LookupFilterByMultipleValues\Index.cshtml"
   Write(Html.AppSourceFile("ProduceSeafoodCategoryEditor.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new Inventory.BasicSamples.LookupFilterByMultipleGrid($('#GridDiv'), {}).init();

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
