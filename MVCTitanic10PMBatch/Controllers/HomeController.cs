using MVCTitanic10PMBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCTitanic10PMBatch.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index(int? id)
        {
            return Content(id.ToString());
        }

        public ActionResult Index1(EmployeeModel emp)
        {
            return Content(emp.EmpId.ToString());
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

  
        [HttpGet]
        public ActionResult UserDashBoard()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            EmployeeEntities db = new Models.EmployeeEntities();
            var userinfo = db.UserDetails.Where(x => x.UserName == user.UserName).FirstOrDefault();
            if (userinfo != null)
            {
                var userpwd = db.UserDetails.Where(x => x.UserName == user.UserName &&  x.Password == user.Password).FirstOrDefault();
                if (userpwd != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("UserDashBoard");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}