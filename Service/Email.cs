using System.Net;
using System.Net.Mail;

public class Email
{
    private string smtpAdress => "smtp.gmail.com";
    private int port => 587;
    private string emailFrom => "senderemail865@gmail.com";
    private string pass => "senderemail865@gmail.com";
    
   public void MailAdd(MailMessage msg, string[] emails)
    {
        foreach (var mail in emails)
        {
            msg.To.Add(mail);
        }
    }

   public void SendMail(string[] emails, string subject, string body, bool html = false)
    {
        using (MailMessage msgMail =  new MailMessage())
        {
            msgMail.From = new MailAddress(emailFrom);
            MailAdd(msgMail, emails);
            msgMail.Subject = subject;
            msgMail.Body = body;
            msgMail.IsBodyHtml = html;
            using (SmtpClient smtp = new SmtpClient(smtpAdress, port))
            {
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(emailFrom, pass);
                smtp.Send(msgMail);
            }
        }
    }

}