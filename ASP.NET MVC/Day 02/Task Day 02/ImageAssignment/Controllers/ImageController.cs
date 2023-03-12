using ImageAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ImageAssignment.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult submitForm(int id , string name , string img)
        {
            ViewBag.Employee = new Employee() { Id = id, Name = name, Img = "/images/" + img };
            return View();
        }

    }
}