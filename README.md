## Start
`git clone https://github.com/ze-fernando/EmailSender-csharp`

`cd EmailSender-csharp`

`dotnet run`

Make your request POST in url:
[http://localhost:5211/api/mails](http://localhost:5211/api/mails)

**Json**

```yaml
{
  "emails":[
    "emai_l0@gmail.com",
    "email_1@gmail.com"
  ],
  "subject": "this is a test",
  "body": "this is a body",
  "isHtml": false
}
```

*You can add one or more addresses to “emails” to send to as many as you want.*

Make with:

![.net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
