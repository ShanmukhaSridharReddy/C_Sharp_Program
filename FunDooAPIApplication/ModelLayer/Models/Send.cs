using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;

namespace ModelLayer.Models
{
    public class Send
    {
        public string SendMail(string emailTo, string token)
        {
            string emailFrom = "shanmukhasridharreddy@gmail.com";
            MailMessage message = new MailMessage(emailFrom,emailTo);
            string mailBody = "Token Generated" + token;
            message.Subject = "Token Will Expire after 1 Hour";
            message.Body = mailBody.ToString();
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            NetworkCredential credential = new NetworkCredential("shanmukhasridharreddy@gmail.com", "hmpf wscs fbcv tigv");
            
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = credential;

            smtpClient.Send(message);
            return emailTo;
        }
    }
}
