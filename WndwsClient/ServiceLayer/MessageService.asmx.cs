using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using LibraryClass;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace ServiceLayer
{
    /// <summary>
    /// Summary description for MessageService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MessageService : System.Web.Services.WebService
    {
        public static bool NameTaken
        {
            get;
            set;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void checkUserName(string pUsername)
        {
        }
        [WebMethod]
        public static void sendEmail()
        {
            //MailMessage m = new MailMessage();
            //SmtpClient sc = new SmtpClient();
            //m.From = new MailAddress("nicolajstr@gmail.com", "Nicolaj Stær");
            //m.To.Add(new MailAddress("marcusulsoe@gmail.com", "Marcus Ulsø"));

            //m.Subject = "Test";
            //m.Body = "This is a test mail but you forgot a password anyway UNDERTALE HILDA";
        }
        [WebMethod]
        public static void sendMail()
        {
            var fromAddress = new MailAddress("nicolajstr@gmail.com", "Nicolaj Stær");
            var toAddress = new MailAddress("marcusulsoe@gmail.com", "Marcus Ulsø");

            const string fromPassword = "Synopsisklamp22";
            const string subject = "Hello World";
            const string body = "This is a test message to your e-amil";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
