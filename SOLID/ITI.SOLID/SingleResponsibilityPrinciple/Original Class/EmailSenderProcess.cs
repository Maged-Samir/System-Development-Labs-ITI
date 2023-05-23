using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosedPrinciple.Original_Class
{
    // Original EmailSender class violating SRP
    public class EmailSenderProcessOriginal
    {
        public void SendEmail(string recipient, string subject, string message)
        {
            // Email sending logic

            // Logging email information
            LogEmailInformation(recipient, subject, message);
        }

        private void LogEmailInformation(string recipient, string subject, string message)
        {
            // Logging logic
        }
    }
}

