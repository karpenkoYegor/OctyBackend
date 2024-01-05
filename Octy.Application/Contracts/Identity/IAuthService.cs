using System.Threading.Tasks;
using Octy.Application.Models.Identity;

namespace Octy.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest  request);
    }
}