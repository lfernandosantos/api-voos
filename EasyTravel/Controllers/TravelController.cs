﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTravel.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        public ActionResult Index()
        {
            return View();
        }
    }
}