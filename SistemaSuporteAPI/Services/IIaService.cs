namespace SistemaSuporte.Api.Services;

public interface IIaService
{
    Task<string> AskAsync(string prompt);
}