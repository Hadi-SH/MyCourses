using MyCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCourses.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Course
        public ActionResult Index()
        {
            var myModel = db.Course.ToList();
            return View(myModel);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(Courses Course)
        {
            if (ModelState.IsValid)
            {
                db.Course.Add(Course);
                db.SaveChanges();

                return RedirectToAction("Index", "Course");
            }
            else return View();
        }


        // GET: Course/Assignment
        public ActionResult Assignment()
        {
            return View();
        }

        // POST: Course/Assignment
        [HttpPost]
        public ActionResult Assignment(Courses Course)
        {
            return View();
        }


        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
