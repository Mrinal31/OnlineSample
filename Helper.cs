using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace BillingEngine
{
    public static class Helper
    {
        public static void sendemail(String reciepient ,String fromAddress,String replyTo,String subject,string mailBody)
        {
            System.Net.Mail.SmtpClient SMTPClientService = new System.Net.Mail.SmtpClient();

            SMTPClientService.Host = "yourmailServer";

            // tell the SMTP service what port to use

            SMTPClientService.Port = Convert.ToInt32("portNumber");
            SMTPClientService.Credentials = new System.Net.NetworkCredential("id", "YourPASSword");
            System.Net.Mail.MailMessage EmailMsgObj = new System.Net.Mail.MailMessage();
            EmailMsgObj.IsBodyHtml = true;

            if (reciepient == "*default" || reciepient == String.Empty)
                EmailMsgObj.To.Add("Toaddress");
            else
                EmailMsgObj.To.Add(reciepient);



            if (fromAddress == "*default" || fromAddress == String.Empty)
                fromAddress = "fromAddress";
            EmailMsgObj.From = new System.Net.Mail.MailAddress(fromAddress);

            if (replyTo == "*default" || replyTo == String.Empty)
                EmailMsgObj.ReplyToList.Add("ReplyToAddress");
            else
                EmailMsgObj.ReplyToList.Add(replyTo);

            EmailMsgObj.Subject = subject;

            EmailMsgObj.Body = mailBody.ToString();
            SMTPClientService.Send(EmailMsgObj);


        }
    }
}
