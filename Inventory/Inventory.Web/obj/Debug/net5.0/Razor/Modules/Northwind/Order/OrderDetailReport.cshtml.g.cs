#pragma checksum "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f96bffa6253e513faad4073b7d4e8b3e1121741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Northwind_Order_OrderDetailReport), @"mvc.1.0.view", @"/Modules/Northwind/Order/OrderDetailReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f96bffa6253e513faad4073b7d4e8b3e1121741", @"/Modules/Northwind/Order/OrderDetailReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709696f6457805a38702a962aec1174e381c722d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Northwind_Order_OrderDetailReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inventory.Northwind.OrderDetailReportData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
 if ((bool?)ViewData["Printing"] == true)
{
    Layout = MVC.Views.Shared._LayoutNoNavigation;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"invoice\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <h2 class=\"page-header\">\r\n                Invoice\r\n                <small class=\"pull-right\">Date: ");
#nullable restore
#line 13 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                                           Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
            </h2>
        </div>
    </div>
    <!-- info row -->
    <div class=""row invoice-info"">
        <div class=""col-sm-4 invoice-col"">
            From
            <address>
                <strong>Northwind, Inc.</strong><br>
                1357 Serenity Road<br>
                Visual Studio Gallery, VS 97653<br>
                Phone: (804) 123-5432<br>
                Email: info@northwind.net
            </address>
        </div>
        <!-- /.col -->
        <div class=""col-sm-4 invoice-col"">
            To
            <address>
                <strong>");
#nullable restore
#line 33 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                   Write(Model.Customer.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n                ");
#nullable restore
#line 34 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
           Write(Model.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Phone: ");
#nullable restore
#line 35 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                  Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Fax: ");
#nullable restore
#line 36 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                Write(Model.Customer.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </address>\r\n        </div>\r\n        <!-- /.col -->\r\n        <div class=\"col-sm-4 invoice-col\">\r\n            <b>Invoice #IX");
#nullable restore
#line 41 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                      Write(Model.Order.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br>\r\n            <br>\r\n            <b>Order ID:</b> ");
#nullable restore
#line 43 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                        Write(Model.Order.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            <b>Payment Due:</b> ");
#nullable restore
#line 44 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                           Write(Model.Order.OrderDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
        <div class=""col-xs-12 table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Unit Price</th>
                        <th>Quantity</th>
                        <th>Discount</th>
                        <th>Line Total</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 63 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                     foreach (var d in Model.Details)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                           Write(d.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.UnitPrice.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.Quantity.ToStringDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.Discount.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.LineTotal.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <!-- /.col -->
    </div>

    <div class=""row"">
        <div class=""col-xs-6"">

        </div>
        <!-- /.col -->
        <div class=""col-xs-6"">
            <p class=""lead"">Amount Due ");
#nullable restore
#line 85 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                                   Write(Model.Order.OrderDate.Value.AddDays(10).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 87 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
              
                var subTotal = Model.Details.Sum(x => x.LineTotal ?? 0);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"table-responsive\">\r\n                <table class=\"table\">\r\n                    <tr>\r\n                        <th style=\"width:50%\">Subtotal:</th>\r\n                        <td>$");
#nullable restore
#line 95 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                        Write(subTotal.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Tax (9.3%)</th>\r\n                        <td>$");
#nullable restore
#line 99 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                         Write((subTotal * 0.093m).ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th>Shipping:</th>
                        <td>$5.80</td>
                    </tr>
                    <tr>
                        <th>Total:</th>
                        <td>$");
#nullable restore
#line 107 "C:\Users\flave\source\repos\Inventory\Inventory\Inventory.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                         Write((subTotal * 1.093m).ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventory.Northwind.OrderDetailReportData> Html { get; private set; }
    }
}
#pragma warning restore 1591
