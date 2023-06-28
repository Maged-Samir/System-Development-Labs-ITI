using Microsoft.AspNetCore.Mvc;

namespace ITI.Revision.MVC.Controllers
{
    public class DemoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //Powerful Mapping Of MVC 
        //Port/Controller/Action/{Parameter}

        public string TestString()
        {
            return "Hello World !";
        }

        public FileResult TestFile()
        {
            return File("~/Files/TextFile.txt", "text/plain");
        }

        public ContentResult TestContent()
        {
            return Content(
           "Test Our Content Result"
                );
        }


        public JsonResult TestJson()
        {
            return Json(new { Name = "Zain Ul Hassan", ID = 1 });
        }

        public ViewResult TestView()
        {

            return View();
        }

        public IActionResult TestActionResult()
        {
            return View();
        }


    }
}
