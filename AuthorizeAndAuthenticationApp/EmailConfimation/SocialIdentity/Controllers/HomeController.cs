﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialIdentity.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin, Student")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Student")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "Student")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}