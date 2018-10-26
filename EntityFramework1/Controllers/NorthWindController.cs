using EntityFramework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework1.Controllers;

namespace EntityFramework1.Controllers
{
    public class NorthWindController : Controller
    {
        NorthWindContext db = new NorthWindContext();

        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.ProductTable.ToList();

            return View();
        }
    }
}