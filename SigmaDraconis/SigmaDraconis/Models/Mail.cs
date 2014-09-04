using SigmaDraconisData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SigmaDraconis.Models
{
    public class Mail
    {
        private MailAddress fromAddress;
        private string fromPassword;
        SmtpClient smtp;
        private string url;
        public Mail()
        {
            fromAddress = new MailAddress("sigmadraconisguild@gmail.com", "Sigma Draconis Guild");
            fromPassword = "SigmaDragon";
            smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromAddress.Address, fromPassword);
            smtp.Timeout = 20000;
            url = "http://localhost:4491/Account/Verify/";
        }
        
        public void RegisterMail(User user)
        {
            MailAddress toAddress = new MailAddress(user.Email, user.Username);
            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = "Your registration at the Sigma Draconis Guild website";
            message.IsBodyHtml = true;
            string link = url + user.Code;
            message.Body = "Hello " + user.Username + ", <br> Your registration is almost complete, please click or copy the following link: <br> <a href='" + link + "'>" + link + "</a><br>Greetings, Sigma Draconis";
            smtp.Send(message);
        }
    }
}