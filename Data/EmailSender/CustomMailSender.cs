using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using System.Net;

namespace BlazorScoreAppPostgre.Data.EmailSender
{
    public class CustomMailSender : IEmailSender<ApplicationUser>
    {
        private readonly IConfiguration _config;

        public CustomMailSender(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
        {
            string fromEmail = _config["GMAIL_ADDRESS"];
            string fromUserName = "メール自動送信システム";
            var fromAddress = new MailAddress(fromEmail, fromUserName);
            string fromPassword = _config["GMAIL_APP_PASSWORD"];

            string toEmail = email; //★(a)送信先メールアドレス
            string toUserName = user.UserName; //★(b)送信先ユーザー名
            var toAddress = new MailAddress(toEmail, toUserName);

            string subject = "アカウント確認のリンク";
            //★(c)HTMLエンコードされたリンクをデコードする
            string decodedLink = WebUtility.HtmlDecode(confirmationLink);
            //★(d)メール本文へのリンクの埋め込み
            string body = $"以下のリンクをクリックしてアカウントを確認してください： {decodedLink}";

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                await smtp.SendMailAsync(message);
            }
        }

        public async Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
        {
            string fromEmail = _config["GMAIL_ADDRESS"];
            string fromUserName = "メール自動送信システム";
            var fromAddress = new MailAddress(fromEmail, fromUserName);
            string fromPassword = _config["GMAIL_APP_PASSWORD"];

            string toEmail = email; //★(a)送信先メールアドレス
            string toUserName = user.UserName; //★(b)送信先ユーザー名
            var toAddress = new MailAddress(toEmail, toUserName);

            string subject = "パスワード再設定のリンク";
            //★(c)HTMLエンコードされたリンクをデコードする
            string decodedLink = WebUtility.HtmlDecode(resetLink);
            //★(d)メール本文へのリンクの埋め込み
            string body = $"以下のリンクをクリックしてパスワードを再設定してください： {decodedLink}";

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                await smtp.SendMailAsync(message);
            }
        }


        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
        {
            //Todo : パスワードリセット用のコードを送信する
            throw new NotImplementedException();
        }
    }
}
