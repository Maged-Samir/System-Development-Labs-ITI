using Day01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestCounterController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return RequestCounterMiddleware.GetRequestCount();
        }
    }
}
