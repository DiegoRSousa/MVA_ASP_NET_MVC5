﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_ASP_NET_MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descreva Sua aplicação.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contato da página.";

            return View();
        }
    }
}