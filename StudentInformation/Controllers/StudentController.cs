using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInformation.Controllers
{
    public class StudentController : Controller
    {
        private StudentDb db = new StudentDb();


        public ActionResult Index(string search)
        {


            if (search != null)
            {
                return View(db.studentInfos.Where(x => x.Name.Contains(search)).ToList());
            }
            else
            {
                return View(db.studentInfos.ToList());
            }
        }
        public ActionResult Create()
        {
         
            return View();

        }

        [HttpPost]
        public ActionResult Create(StudentInfo s)
        {
            db.studentInfos.Add(s);
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}