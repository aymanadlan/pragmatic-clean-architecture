
using Bookify.Application.Abstractions.Email;
using Bookify.Domain.Abstractions;

namespace Bookify.Infrastructure.Email;

public class EmailService : IEmailService
{
    public Task SendAsync(Domain.Users.Email recipient, string subject, string body)
    {
        return Task.CompletedTask;
    }
}
