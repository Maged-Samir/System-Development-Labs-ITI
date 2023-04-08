
using Day01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace APIs.Day1.Filters;

public class ValidateCarTypeAttribute : ActionFilterAttribute
{
    private readonly ILogger<ValidateCarTypeAttribute> _logger;
    public ValidateCarTypeAttribute(ILogger<ValidateCarTypeAttribute> logger)
    {
        _logger = logger;
        
    }
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        _logger.LogWarning("Filter execution started");
        Car? car = context.ActionArguments["car"] as Car;

        var regex = new Regex("^(Electric|Gas|Hybrid)$",
            RegexOptions.IgnoreCase,
            TimeSpan.FromSeconds(2));

        if (car is null || !regex.IsMatch(car.Type))
        {
            //Short Circuit with BadRequest
            context.ModelState.AddModelError("Type", "Please Cheak Your Type Again !!");
            context.Result = new BadRequestObjectResult(context.ModelState);
        }
    }
}
