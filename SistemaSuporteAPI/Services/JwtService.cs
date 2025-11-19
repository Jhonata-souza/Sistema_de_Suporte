using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SistemaSuporte.Api.Services;

public class JwtService : IJwtService
{
    private readonly IConfiguration _config;
    private readonly string _issuer;
    private readonly string _audience;
    private readonly string _key;
    private readonly int _expiresMinutes;

    public JwtService(IConfiguration config)
    {
        _config = config;
        _issuer = _config["Jwt:Issuer"]!;
        _audience = _config["Jwt:Audience"]!;
        _key = _config["Jwt:Key"]!;
        _expiresMinutes = int.Parse(_config["Jwt:ExpiresMinutes"] ?? "1440");
    }

    public string GenerateToken(int userId, string email, string role)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
            new Claim(ClaimTypes.Email, email),
            new Claim(ClaimTypes.Role, role)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = DateTime.UtcNow.AddMinutes(_expiresMinutes);

        var token = new JwtSecurityToken(
            issuer: _issuer,
            audience: _audience,
            claims: claims,
            expires: expires,
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}