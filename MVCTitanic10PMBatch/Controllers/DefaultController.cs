using MVCTitanic10PMBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTitanic10PMBatch.Controllers
{
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

        public string getKitkat(int? id,string name, string designation)
        {

            return "My Emp id "+id+" Name is"+name+" Designation:"+designation;
        }

        public string getKitkat1(int? id)
        {

            return "My Emp id " + id + " Name is" +Request.QueryString["name"] + " Designation:"  +Request.QueryString["designation"];
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

        public ViewResult getmeHonda() {
            return View() ;
        }
        public ActionResult getmeHonda2()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult getmeHonda3() {

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

            return RedirectToAction("Index","Home",new {id=1});
        }

        public RedirectToRouteResult getmeHonda7()
        {

            emp.EmpId = 1211;
            emp.EmpName = "Prince";
            emp.EmpSalary = 190000;

            return RedirectToAction("Index1", "Home",emp);
        }
    }
}