using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ServiceLayer
{
    public class MailClass:System.Web.Mail.MailMessage
    {
        private static string _gmailServer = "smtp@gmail.com";
        private static long _gmailPort = 465;
        private string _gmailUsername = string.Empty;
        private string _gmailPassword = string.Empty;

        public MailClass(string gmailUsername, string gmailPassword)
        {
           // this.Fields[] = MailClass.gm
        }

        public string GmailUserName
        {
            get { return _gmailUsername; }
            set { _gmailUsername = value; }
        }
        public string GmailPassword
        {
            get { return _gmailPassword; }
            set { _gmailPassword = value; }
        }

        public static void SendFromGmail(string gmailUserName, string gmailPassword, string toAddress, string subject, string messageBody)
        {
            try
            {
                MailClass gMessage = new MailClass(gmailUserName, gmailPassword);

                gMessage.To = toAddress;
                gMessage.Subject = subject;
                gMessage.Body = messageBody;
                gMessage.From = gmailUserName;
                if (gmailUserName.IndexOf('@') == -1) gMessage.From += "@Gmail.com";

                System.Web.Mail.SmtpMail.Send(gMessage);
            }
            catch (Exception ex)
            {
                //TODO: Add error handling
                throw ex;
            }
        }
    }
}