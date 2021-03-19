using MVCTitanic10PMBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTitanic10PMBatch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            return Content(id.ToString());
        }

        public ActionResult Index1( EmployeeModel emp)
        {
            return Content(emp.EmpId.ToString());
        }
    }
}