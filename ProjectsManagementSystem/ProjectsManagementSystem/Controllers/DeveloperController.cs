﻿using ProjectsManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsManagementSystem.Controllers
{
    public class DeveloperController : Controller
    {
        PROJECT_MANAGEMENTEntities1 db = new PROJECT_MANAGEMENTEntities1();
        // GET: Developer
        public ActionResult Index()
        {
            return View();
        }
    }
}