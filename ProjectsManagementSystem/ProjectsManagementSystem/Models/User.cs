using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectsManagementSystem.Models
{
    public class User
    {
        public string user_password { get; set; }
        public string name { get; set; }
        public int expeirenceYears { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string img { get; set; }
        public string job_Desc { get; set; }
        public int JobID { get; set; }
        public List<Job_Title> titles  { get; set; }
    }
}