using ProductApi.Models;

namespace ProductApi.Services;

public interface IAuthService
{
    Task<string?> AuthenticateAsync(string username, string password);
    Task<User> RegisterAsync(string username, string password);
}