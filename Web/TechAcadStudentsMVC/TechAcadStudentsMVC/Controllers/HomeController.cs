﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                Firstame = "Engels",
                LastName = "Molina"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    Firstame = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    Id = 2,
                    Firstame = "Brett",
                    LastName = "Calendar"
                },
                new Instructor
                {
                    Id = 3,
                    Firstame = "Adam",
                    LastName = "Smithsonian"
                }
            };

            return View(instructors);
        }
    }
}