using System.Collections.Generic;
using System.Threading.Tasks;
using Octy.Application.Models.Identity;

namespace Octy.Application.Contracts.Identity
{
    public interface IUserService
    {
        Task<List<User>> GetStudentsAsync();
        Task<User> GetUserAsync(string userId);
    }
}