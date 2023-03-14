using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskDayFour.Areas.Admin.Controllers
{
    [HandleError(View = "UnderConstractionCustomError")]
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            throw new Exception();
        }
    }
}