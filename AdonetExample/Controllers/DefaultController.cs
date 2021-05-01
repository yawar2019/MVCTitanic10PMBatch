﻿using AdonetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdonetExample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.getEmployees());
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployees(emp);

            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection frm)
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {

            int i = db.UpdateEmployees(emp);

            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {

            int i = db.DeleteEmployee(id);

            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult HtmlHelperExample()
        {

            EmployeeEntities db = new EmployeeEntities();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Lahrika";
            ViewBag.department = new SelectList(db.Departments, "DeptId", "DeptName");

            return View(emp);
        }


        public ActionResult GetAccessService()
        {
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            ViewBag.info=obj.Add(12, 25);
            return View();
        }


    }
}