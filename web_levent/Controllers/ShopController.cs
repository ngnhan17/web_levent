﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_levent.Models;

namespace web_levent.Controllers
{
    public class ShopController : Controller
    {
        leventEntities db = new leventEntities();
        // GET: Shop
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}