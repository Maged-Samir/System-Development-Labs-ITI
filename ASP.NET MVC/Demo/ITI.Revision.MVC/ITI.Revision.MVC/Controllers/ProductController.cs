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


        //This is only simple example for using html Helpers

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View("AddProduct");
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if(product.ID !=null && product.Name != null)
            {
                Product.products.Add(product); // Add the new product to the static list
            }
            return RedirectToAction("GetAll");
        }


        //This is only simple example for using html Helpers
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            Product product = Product.products.FirstOrDefault(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(int id, Product updatedProduct)
        {
            if (ModelState.IsValid)
            {
                Product product = Product.products.FirstOrDefault(p => p.ID == id);
                if (product == null)
                {
                    return NotFound();
                }

                // Update the product with the new values
                product.Name = updatedProduct.Name;
                product.Qty = updatedProduct.Qty;
                product.Price = updatedProduct.Price;

                return RedirectToAction("GetAll");
            }

            return View(updatedProduct);
        }

        //This is only simple example for using AJAX with MVC 
        public ActionResult Search(string searchTerm)
        {
            var results = Product.products.Where(p => p.Name.Contains(searchTerm)).ToList();
            return PartialView("_SearchResults", results);
        }


    }
}
