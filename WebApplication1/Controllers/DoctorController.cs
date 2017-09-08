using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {


        List<Doctor> list = new List<Doctor>();


        public DoctorController()
        {

            var d1 = new Doctor();
            d1.Degree = "MBBS";
            d1.Id = 1;
            d1.Name = "Dr. Wajid";
            d1.Experience = 10;

            list.Add(d1);
            list.Add(new Doctor() { Degree = "MBBS", Experience = 4, Name = "Ali", Id = 2 });
        }
        public ActionResult Index()
        {
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Doctor doc)
        {
            //database code fo finsert doctor entity in chapter 6.

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            var editing = list.Find(d => d.Id == Id);
            return View(editing);
        }


        public ActionResult Details(int Id)
        {
            var doc = list.Find(d => d.Id == Id);
            return View(doc);
        }


    }
}