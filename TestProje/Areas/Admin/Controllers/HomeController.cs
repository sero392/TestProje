﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProje.Data;
using TestProje.Models.DbModels;

namespace TestProje.Areas.Admin.Controllers
{
    public class HomeController : Controller
    { 
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }


    }
}