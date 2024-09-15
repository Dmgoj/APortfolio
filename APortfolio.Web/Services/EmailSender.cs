using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace APortfolio.Web.Services // Adjust the namespace based on your project's structure
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Implement your email sending logic here.
            // For example, using SMTP or a third-party service like SendGrid, Mailgun, etc.
            return Task.CompletedTask; // Placeholder for actual implementation
        }
    }
}
