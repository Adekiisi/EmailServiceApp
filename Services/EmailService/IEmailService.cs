using EmailServiceApp.Models;

namespace EmailServiceApp.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
