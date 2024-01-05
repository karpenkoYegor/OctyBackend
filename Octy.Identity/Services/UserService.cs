using Microsoft.AspNetCore.Identity;
using Octy.Application.Contracts.Identity;
using Octy.Application.Models.Identity;
using Octy.Identity.Models;

namespace Octy.Identity.Services;

public class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }
    public async Task<List<User>> GetStudentsAsync()
    {
        var students = await _userManager.GetUsersInRoleAsync("Student");
        return students.Select(q => new User
        {
            Id = q.Id,
            Email = q.Email,
            FirstName = q.FirstName,
            LastName = q.LastName
        }).ToList();
    }

    public async Task<User> GetUserAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        return new User
        {
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Id = user.Id
        };
    }
}