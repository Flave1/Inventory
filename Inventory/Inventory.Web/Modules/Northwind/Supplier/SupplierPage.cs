﻿using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace Inventory.Northwind.Pages
{
    [PageAuthorize(typeof(Entities.SupplierRow))]
    public class SupplierController : Controller
    {
        [Route("Northwind/Supplier")]
        public ActionResult Index()
        {
            return View(MVC.Views.Northwind.Supplier.SupplierIndex);
        }
    }
}
