using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace AppointmentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentStatusController : ControllerBase
    {
        private static ConcurrentDictionary<Guid, string> AppointmentStatuses = new ConcurrentDictionary<Guid, string>();


        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            return AppointmentStatuses.TryGetValue(id, out var status) ?
                 Ok(status) : NotFound($"No matched record for {id}");
        }



        [HttpPut]
        public IActionResult UpdateStatus(AppointmentStatus status)
        {
            AppointmentStatuses.AddOrUpdate(status.Id, status.Status, (id, sts) => status.Status);

            return Ok();
        }

    }
}
