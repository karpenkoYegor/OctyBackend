using System.Threading.Tasks;
using Octy.Application.Models;

namespace Octy.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}