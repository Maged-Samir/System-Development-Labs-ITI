using Microsoft.Office.Interop.Outlook;
using System.Net.Mail;
using System.Net;

namespace ITI.SendingEmails.API.EmailService
{
    public class EmailService
    {
        //public void SendEmail(string recipient, string subject, string body)
        //{
        //    string senderEmail = "";
        //    string senderPassword = "";

        //    SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
        //    smtpClient.UseDefaultCredentials = false;
        //    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
        //    smtpClient.EnableSsl = true;

        //    MailMessage mailMessage = new MailMessage();
        //    mailMessage.From = new MailAddress(senderEmail);
        //    mailMessage.To.Add(recipient);
        //    mailMessage.Subject = subject;
        //    mailMessage.Body = body;

        //    smtpClient.Send(mailMessage);
        //}


        public void SendEmail(string recipient, string subject)
        {
            string senderEmail = "";
            string senderPassword = "";

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(senderEmail);
            mailMessage.To.Add(recipient);
            mailMessage.Subject = subject;

            // Set the body of the email to a static HTML page
            string body = @"<!DOCTYPE html>
                <html>
                <head>
                    <title>Welcome to Our Site</title>
                    <style>
                        /* CSS styles */
                        body {
                            font-family: Arial, sans-serif;
                            background-color: #f5f5f5;
                            margin: 0;
                            padding: 0;
                        }
                        .container {
                            max-width: 600px;
                            margin: 0 auto;
                            padding: 20px;
                            background-color: #fff;
                        }
                        h1 {
                            color: #333;
                        }
                        p {
                            color: #555;
                            line-height: 1.5;
                        }
                        .logo {
                            text-align: center;
                            margin-bottom: 20px;
                        }
                        .logo img {
                            max-width: 200px;
                            height: auto;
                        }
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='logo'>
                            <img src='https://static.cdnlogo.com/logos/f/22/ferrari.svg' alt='Logo'>
                        </div>
                        <h1>Welcome to Our Site</h1>
                        <p>Thank you for registering with us. We are excited to have you on board!</p>
                        <p>If you have any questions or need assistance, please feel free to contact us.</p>
                        <p>Best regards,</p>
                        <p>Your Site Team</p>
                    </div>
                </body>
                </html>";

            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;

            smtpClient.Send(mailMessage);
        }


    }
}
