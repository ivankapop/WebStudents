using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebStudents.Models;

namespace WebStudents.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db;
        public HomeController(StudentContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
           
                var score = db.Scores
                .Include("Student")
                .Include("Subject");

            return View(score.ToList());
        }


        public string ProceedResult(string name,  int id)
        {
            Student studik = new Student()
            {
                Name = name,
                Id = id
            };

            return $"Name:{studik.Name}, id:{studik.Id}.";
        }

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
