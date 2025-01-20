using ClassLibrary1.Entities;

namespace C_ServiceLayer.Abstractions;

public interface IAuthService
{
    int? GetUserIdFromToken(string token);

    string GenerateAccessTokenString(User? user);
    string GenerateRefreshTokenString();

}