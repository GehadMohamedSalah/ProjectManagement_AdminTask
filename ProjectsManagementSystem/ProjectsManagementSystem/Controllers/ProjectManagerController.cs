using ProjectsManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsManagementSystem.Controllers
{
    public class ProjectManagerController : Controller
    {
        PROJECT_MANAGEMENTEntities1 db = new PROJECT_MANAGEMENTEntities1();
        // GET: PM
        public ActionResult Index()
        {
            return View();
        }
    }
}