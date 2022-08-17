using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_CodeFirst_Demo.Models;//to access DBContext and Model classes

namespace EF_CodeFirst_Demo.Controllers
{
    public class StudnetController : Controller
    {
        // GET: Studnet
        PGDACContext db = new PGDACContext();
        public ActionResult Index()
        {
            //ViewBag.DbName = db.Database.Connection.Database;
            //List<Student> data=db.Students.ToList();
            return View(db.Students.Include("Address").ToList());
        }

        //for insertion
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                //insert work
                db.Students.Add(student);//add will save passed entity in current context
                db.SaveChanges();//will update the changes in database
                return RedirectToAction("Index");//redirecting to Index Action
            }
            return View(student);
        }





    }
}