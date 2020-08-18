using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public JsonResult GetAllItems()
        {
            var db = new Context();
            var query = from items in db.ItemsInBoxes select new { items.part_code, items.part_name };
            return Json(query, JsonRequestBehavior.AllowGet);
        }
    }
}
