namespace SistemaSuporte.Api.Services;

public interface IJwtService
{
    string GenerateToken(int userId, string email, string role);
}