using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using BLL;
using Model;
using EF;

namespace WebApplication5.Controllers
{
    public class StudentController : Controller
    {
        IStudentBLL<StudentModel> sb = new StudentBLL();
        // GET: Student
        public ActionResult Index()
        {
            List<StudentModel> list = sb.Select();
            return View(list);
        }
    }
}