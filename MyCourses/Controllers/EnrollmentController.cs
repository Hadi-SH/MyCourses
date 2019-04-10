using MyCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCourses.Controllers
{
    public class EnrollmentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Enrollment
        public ActionResult Index()
        {
            var myModel = db.Enrollment.ToList();
            return View(myModel);
        }

        // GET: Enrollment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Enrollment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enrollment/Create
        [HttpPost]
        public ActionResult Create(Enrollments Enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Enrollment.Add(Enrollment);
                db.SaveChanges();

                return RedirectToAction("Index", "Enrollment");
            }
            else return View();
        }

        // GET: Enrollment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Enrollment/Edit/5
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

        // GET: Enrollment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Enrollment/Delete/5
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
