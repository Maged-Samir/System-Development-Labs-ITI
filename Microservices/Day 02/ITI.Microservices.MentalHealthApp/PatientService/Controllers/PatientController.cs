using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PatientService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IHttpClientFactory httpClientFactory;
        public PatientController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        public async Task<IActionResult> BookAppointment(BookRequest request)
        {
            var client = httpClientFactory.CreateClient();

            var response = await client.PutAsJsonAsync("https://localhost:8596/api/AppointmentStatus", new AppointmentStatus
            {
                Id = request.Id,
                Status = "Book New Appointment"
            });

            if (response.IsSuccessStatusCode)
            {
                return Ok("Your Appointment has been Booked");
            }

            return BadRequest(response);
        }

        }
}
