using DifferenceViewDataAndViewBag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DifferenceViewDataAndViewBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message1"] = "Data comes from ViewData";
            ViewBag.Message2 = "Data comes from ViewBag";

            ViewData["CurrentDate1"] = DateTime.Now.ToString();
            ViewBag.CurrentDate2 = DateTime.Now.ToString();

            string[] games = { "Hockey", "Football", "Cricket", "Baseball" };
            ViewData["GamesArray1"] = games;
            ViewBag.GamesArray2 = games;

            Employee obj = new Employee();
            obj.EmpId = 11;
            obj.EmpName = "Amit";
            obj.EmpAge = 23;

            ViewData["Employee1"] = obj;
            ViewBag.Employee2 = obj;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}