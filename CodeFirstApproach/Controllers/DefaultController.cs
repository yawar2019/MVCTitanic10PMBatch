using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        public ActionResult Create() {

            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModels.Add(emp);//line creating Insert Query
            int i= db.SaveChanges();
            if (i > 0) {
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
             
        }

        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }

        }
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            db.EmployeeModels.Remove(emp);

            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }

        }

    }
}

//Enable-migrations -Force
//add-migration updatedesignation
//update-databse