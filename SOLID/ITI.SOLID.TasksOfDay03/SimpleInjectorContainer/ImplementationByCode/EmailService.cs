using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryIoc.ImplementationByCode
{
    public class EmailService:IEmailService
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            // Code to send an email
            Console.WriteLine($"[EmailService] Sending email to: {recipient}\nSubject: {subject}\nBody: {body}");
        }
    }
}
