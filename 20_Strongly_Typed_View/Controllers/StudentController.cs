using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20_Strongly_Typed_View.Models;

namespace _20_Strongly_Typed_View.Controllers
{
    public class StudentController : Controller
    {
        //using single object
        public ViewResult Index()
        {
            Student st = new Student() { RollNo = 1, Name = "Abhishek", Address = "Katihar", Course = "B.Tech" };
            return View(st);
        }

        //using collection of objects
        public ViewResult List()
        {
            List<Student> lst = new List<Student>()
            {
                new Student { RollNo = 2, Name="Ramesh", Address="Patna", Course="MBA"},
                new Student { RollNo = 3, Name = "Mahesh", Address = "Jaipur", Course = "MCA" },
                new Student { RollNo = 4, Name = "Suresh", Address = "Ranchi", Course = "M.Sc" }
            };
            return View(lst);
        }
    }
}