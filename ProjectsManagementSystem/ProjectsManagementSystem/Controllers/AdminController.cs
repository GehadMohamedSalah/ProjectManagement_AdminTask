using ProjectsManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectsManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        PROJECT_MANAGEMENTEntities1 db = new PROJECT_MANAGEMENTEntities1();
        [HttpGet]
        public ActionResult AddUser()
        {
            var user = new User();
            user.titles = db.Job_Title.Where(c => c.jobID != 1).ToList();
            return View(user);
        }

        [HttpPost]
        public ActionResult AddUser(string user_password , string name , int expeirenceYears ,
            string phone , string email  , HttpPostedFileBase img , string job_Desc , int JobID )
        {
            var userx = db.Users.Where(c => c.user_password == user_password || c.email == email).ToList();
            if(userx.Count() == 0)
            {
                string fileName = Path.GetFileName(img.FileName);
                var path = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                img.SaveAs(path);
                Users user1 = new Users
                {
                    user_password = user_password,
                    name = name,
                    expeirenceYears = expeirenceYears,
                    phone = phone,
                    email = email,
                    img = fileName,
                    job_Desc = job_Desc,
                    job_id = JobID,
                    No_Of_Delievered_Projects = 0,
                    Profits_For_Companies = 0
                };
                if (ModelState.IsValid)
                {
                    db.Users.Add(user1);
                    db.SaveChanges();
                }
            }
            
            return RedirectToAction("ShowUsers", "Admin");
            
        }

        [HttpGet]
        public ActionResult ShowUsers()
        {
            var users = db.Users.Where(c => c.userID != 1).ToList();
            return View(users);
        }

        public ActionResult DeleteUser(int id)
        {
            var user = db.Users.SingleOrDefault(c => c.userID == id);
            if (ModelState.IsValid)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("ShowUsers", "Admin");
        }

        [HttpGet]
        public ActionResult ShowPosts()
        {
            var posts = db.User_Projects.Where(c => c.Users.Job_Title.jobID == 5 && c.Projects.state == "pending" || (c.Projects.state == "accepted" && c.Projects.assigned == false)).ToList();
            return View(posts);
        }

        public ActionResult AcceptOrRejectPost(int id , string value)
        {
            var user_proj = db.User_Projects.SingleOrDefault(c => c.id == id);
            if(value == "rejected")
            {
                var proj = db.Projects.SingleOrDefault(c => c.projectID == user_proj.project_id);
                db.User_Projects.Remove(user_proj);
                db.Projects.Remove(proj);
            }
            else
            {
                user_proj.Projects.state = value;
            }
            db.SaveChanges();
            return RedirectToAction("ShowPosts", "Admin");
        }

        [HttpGet]
        public ActionResult EditPost(int id)
        {
            var user_proj = db.User_Projects.SingleOrDefault(c => c.id == id);
            return View(user_proj.Projects);
        }

        [HttpPost]
        public ActionResult EditPost(int projectID , string name , string jobDescr)
        {
            var proj = db.Projects.SingleOrDefault(c => c.projectID == projectID);
            proj.name = name;
            proj.jobDescr = jobDescr;
            db.SaveChanges();
            return RedirectToAction("ShowPosts", "Admin");
        }
    }
}