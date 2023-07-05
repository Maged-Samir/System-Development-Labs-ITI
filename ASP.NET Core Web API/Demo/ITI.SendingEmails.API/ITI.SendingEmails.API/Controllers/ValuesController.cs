using ITI.SendingEmails.API.EmailService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITI.SendingEmails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        private readonly EmailService.EmailService _emailService;

        public ValuesController(EmailService.EmailService emailService)
        {
            _emailService = emailService;
        }



        [HttpPost]
        public IActionResult SendEmail([FromBody] EmailModel email)
        {
            // Assuming EmailModel contains recipient, subject, and body properties
            _emailService.SendEmail(email.Recipient, email.Subject);

            return Ok();
        }
    }

    public class EmailModel
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        //public string Body { get; set; }
    }
}

