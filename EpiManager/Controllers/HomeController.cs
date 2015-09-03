﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpiManager.DAL;

namespace EpiManager.Controllers
{
    public class HomeController : Controller
    {
        EpiContext db = new EpiContext();
        public ActionResult Index()
        {
            var lstTemp = db.EpiKind.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}