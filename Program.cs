using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace SendMail {
    class Program {
        static void Main(string[] args) {

            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();

            mail.From = new MailAddress("sbb-gen@hurtigruten.com");
            mail.To.Add(new MailAddress("morten.haugen@ifront.no"));
            client.Port = 25;
//            client.DeliveryMethod = SmtpDeliveryMethod.Network;
//            client.UseDefaultCredentials = false;
//            client.Host = "131.207.84.81";
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);
        }
    }
}

/*
var mailClient = new SmtpClient();
                var mailMessage = new MailMessage();
                mailMessage.Subject = emailSubject;

                mailMessage.From = new MailAddress("sbb-gen@hurtigruten.com");

                string[] addressees = receivers.Split(';');
                foreach (var addressee in addressees) {
                    mailMessage.To.Add(new MailAddress(addressee));
                }

                var bodyBuilder = new StringBuilder();
                bodyBuilder.AppendLine(message);

                if (!String.IsNullOrEmpty(attachmentPath)) {
                    int i = attachmentPath.LastIndexOf('\\');
                    string filename = i > 0 ? attachmentPath.Substring(i+1) : attachmentPath;
                    FileStream fs = new FileStream(attachmentPath, FileMode.Open, FileAccess.Read);
                    Attachment a = new Attachment(fs, filename, MediaTypeNames.Application.Octet);
                    mailMessage.Attachments.Add(a);
                    bodyBuilder.AppendLine("Skipspaper transfer file " + filename + " is attached.");
                    Log.Debug("Mail attachment: "+attachmentPath);
                }

                mailMessage.Body = bodyBuilder.ToString();

                mailClient.Send(mailMessage);
*/