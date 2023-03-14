﻿using System.Web.Mvc;

namespace TaskDayFour.Areas.HR
{
    public class HRAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HR";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HR_default",
                "HR/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}