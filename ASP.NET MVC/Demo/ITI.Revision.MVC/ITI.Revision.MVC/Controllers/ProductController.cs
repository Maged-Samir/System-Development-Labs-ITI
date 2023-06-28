using ITI.Revision.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITI.Revision.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetAll()
        {
            List<string> Categories= new List<string>();
            Categories.Add("Mobile");
            Categories.Add("Labtop");
            Categories.Add("PC");

            ViewData["Cate"] = Categories;

            ViewBag.Categs = Categories;

            List<Product> model = Product.products.ToList();
            return View(model);
        }


        //State Managment  (Sessions - Cookies )
        //01.Sessions
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "Maged");
            HttpContext.Session.SetInt32("Age", 20);
            return Content("Session Has Been Saved successfully!");
        }

        public IActionResult GetSession()
        {
            string? Name = HttpContext.Session.GetString("Name");
            int? Age = HttpContext.Session.GetInt32("Age").Value;

            return Content($"Session Data :{Name} - {Age} Years Old ");
        }

        //02.Cookies
        public IActionResult SetCookie()
        {
            CookieOptions options=new CookieOptions();
            options.Expires=DateTimeOffset.Now.AddDays(1);

            Response.Cookies.Append("Name", "Maged",options);
            Response.Cookies.Append("Age", "20",options);

            return Content("Cookie Has Been Saved successfully!");
        }

        public IActionResult GetCookie()
        {
            string Name = Request.Cookies["Name"].ToString();
            string Age = Request.Cookies["Age"].ToString();

            return Content($"Cookie Data :{Name} - {Age}");
        }



    }
}
