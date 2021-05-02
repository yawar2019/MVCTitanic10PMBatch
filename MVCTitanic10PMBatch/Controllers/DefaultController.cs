using MVCTitanic10PMBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTitanic10PMBatch.Filter;
namespace MVCTitanic10PMBatch.Controllers
{
    [MyFilter]
    public class DefaultController : Controller
    {
        // GET: Default
        [Route("student/mvc")]
        [Route("faculty/mvc")]
        [Route("Admin/mvc")]
        public string Index()
        {
            return "Hello";
        }


        public ActionResult GetMeView()
        {

            return View("~/Views/Home/index.cshtml");

        }

        public string getKitkat(int? id, string name, string designation)
        {

            return "My Emp id " + id + " Name is" + name + " Designation:" + designation;
        }

        public string getKitkat1(int? id)
        {

            return "My Emp id " + id + " Name is" + Request.QueryString["name"] + " Designation:" + Request.QueryString["designation"];
        }

        public ActionResult SendData()
        {

            ViewBag.info = "Virat kohli";
            return View();
        }

        public ActionResult SendData1()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1211;
            emp.EmpName = "Prince";
            emp.EmpSalary = 190000;


            ViewBag.info = emp;
            return View();
        }

        public ActionResult SendData2()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1211;
            emp.EmpName = "Prince";
            emp.EmpSalary = 190000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1212;
            emp1.EmpName = "Vijaya";
            emp1.EmpSalary = 290000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 1211;
            emp2.EmpName = "Lahrika";
            emp2.EmpSalary = 390000;


            listObj.Add(emp);
            listObj.Add(emp1);
            listObj.Add(emp2);



            ViewBag.info = listObj;
            return View();
        }
       
        public ActionResult SendData3()
        {
             
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1211;
            emp.EmpName = "Prince";
            emp.EmpSalary = 190000;

            //object model=emp;

            return View(emp);
        }


        public ActionResult SendData4()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1211;
            emp.EmpName = "Prince";
            emp.EmpSalary = 190000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1212;
            emp1.EmpName = "Vijaya";
            emp1.EmpSalary = 290000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 1211;
            emp2.EmpName = "Lahrika";
            emp2.EmpSalary = 390000;


            listObj.Add(emp);
            listObj.Add(emp1);
            listObj.Add(emp2);




            return View(listObj);
        }

        public ActionResult SendData5()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1211;
            emp.EmpName = "Prince";
            emp.EmpSalary = 190000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1212;
            emp1.EmpName = "Vijaya";
            emp1.EmpSalary = 290000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 1211;
            emp2.EmpName = "Lahrika";
            emp2.EmpSalary = 390000;


            listObj.Add(emp);
            listObj.Add(emp1);
            listObj.Add(emp2);

            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Network";

            List<DepartmentModel> listDeptObj = new List<DepartmentModel>();
            listDeptObj.Add(dept);
            listDeptObj.Add(dept1);


            EmpDept edObj = new Models.EmpDept();
            edObj.emp = listObj;
            edObj.dept = listDeptObj;

            return View(edObj);
        }

        public ViewResult getmeHonda()
        {
            return View();
        }
        public ActionResult getmeHonda2()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult getmeHonda3()
        {

            return Redirect("http://www.google.com");
        }
        public RedirectResult getmeHonda4()
        {
            return Redirect("getmeHonda5/1");
        }

        public ViewResult getmeHonda5(int id)
        {
            ViewBag.id = id;
            return View();
        }

        EmployeeModel emp = new EmployeeModel();



        public RedirectToRouteResult getmeHonda6()
        {

            return RedirectToAction("Index", "Home", new { id = 1 });
        }

        public RedirectToRouteResult getmeHonda7()
        {

            emp.EmpId = 1211;
            emp.EmpName = "Prince";
            emp.EmpSalary = 190000;

            return RedirectToAction("Index1", "Home", emp);
        }

        public RedirectToRouteResult getmeHonda8()
        {
            return RedirectToRoute("Default2");
        }
        public ActionResult GetmeHonda9()
        {
            StudentModel st = new Models.StudentModel();
            st.StudentId = 1;
            st.StudentName = "Prince";

            StudentModel st1 = new Models.StudentModel();
            st1.StudentId = 2;
            st1.StudentName = "Vijaya";

            StudentModel st2 = new Models.StudentModel();
            st2.StudentId = 3;
            st2.StudentName = "Nishikanth";

            List<StudentModel> listObj = new List<StudentModel>();
            listObj.Add(st);
            listObj.Add(st1);
            listObj.Add(st2);

            return View(listObj);
        }

        public PartialViewResult GetmeHonda10()
        {
            StudentModel st = new Models.StudentModel();
            st.StudentId = 1;
            st.StudentName = "Prince";

            StudentModel st1 = new Models.StudentModel();
            st1.StudentId = 2;
            st1.StudentName = "Vijaya";

            StudentModel st2 = new Models.StudentModel();
            st2.StudentId = 3;
            st2.StudentName = "Nishikanth";

            List<StudentModel> listObj = new List<StudentModel>();
            listObj.Add(st);
            listObj.Add(st1);
            listObj.Add(st2);

            return PartialView("_MyPartialView", listObj);
        }

        public FileResult GetmeHonda11()
        {
            return File("~/Web.config", "text/plain");
        }
        public FileResult GetmeHonda12()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }
        public FileResult GetmeHonda13()
        {
            return File("~/ActionResult.pdf", "application/pdf", "ActionResult.pdf");
        }
        public JsonResult GetmeHonda14()
        {
            StudentModel st = new Models.StudentModel();
            st.StudentId = 1;
            st.StudentName = "Prince";

            StudentModel st1 = new Models.StudentModel();
            st1.StudentId = 2;
            st1.StudentName = "Vijaya";

            StudentModel st2 = new Models.StudentModel();
            st2.StudentId = 3;
            st2.StudentName = "Nishikanth";

            List<StudentModel> listObj = new List<StudentModel>();
            listObj.Add(st);
            listObj.Add(st1);
            listObj.Add(st2);

            return Json(listObj, JsonRequestBehavior.AllowGet);
        }

        public ContentResult GetmeHonda15(int? id)
        {
            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id ==2)
            {
                return Content("<p style='color:red'>Hello World</p>");

            }
            else
	        {
                return Content("<script>alert('Hello World')</script>");
            }
        }

        [MyFilter]
        public ActionResult ElectionResult() {
            ViewBag.favoriteHero = "Nadda";

            return View();
        }
    }
}