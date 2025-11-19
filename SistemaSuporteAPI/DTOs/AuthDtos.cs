namespace SistemaSuporte.Api.DTOs;

public record RegisterDto(string Email, string Password, string? Name);
public record LoginDto(string Email, string Password);
public record AuthResponseDto(string Token, int UserId, string Email, string Role);