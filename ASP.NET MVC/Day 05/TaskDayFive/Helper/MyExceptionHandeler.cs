using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace TaskDayFive.Helper
{
    public class MyExceptionHandeler:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled= true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "CustomError",
            };

            base.OnException(filterContext);
        }
    }
}