using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpiManager.DAL;

namespace EpiManager.Controllers
{
    public class EpiController : Controller
    {
        public ActionResult Customers(string searchTerm)
        {
            var customers = ContextHelper.CustomerFilter(searchTerm);
            var result = new JsonResult { Data = customers, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            return result;
        }
    }
}