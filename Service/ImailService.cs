public interface ImailService
{
    void SendMail(string[] emails, string subject, string body, bool html = false);
}