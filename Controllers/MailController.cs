using Microsoft.AspNetCore.Mvc;

[ApiController]
public class MailController : ControllerBase
{
    private readonly ImailService _mailService;
    public MailController(ImailService mailService)
    {
        _mailService = mailService;
    }


    [HttpPost("api/mails")]
    public IActionResult SendMail([FromBody] SendMailVM mailVM)
    {   
        _mailService.SendMail(mailVM.Emails, mailVM.Subject, mailVM.Body, mailVM.isHtml);

        return Ok();
    }
}
