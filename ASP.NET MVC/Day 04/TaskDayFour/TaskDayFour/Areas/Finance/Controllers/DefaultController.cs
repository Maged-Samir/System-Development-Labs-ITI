using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskDayFour.Areas.Finance.Controllers
{
    [HandleError(View = "UnderConstractionCustomError")]
    public class DefaultController : Controller
    {
        // GET: Finance/Default
        public ActionResult Index()
        {
           throw new Exception();
        }
    }
}