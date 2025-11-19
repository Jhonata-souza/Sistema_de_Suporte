using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SistemaSuporte.Api.Services;

public class IaService : IIaService
{
    private readonly HttpClient _http;
    private readonly string _apiKey;

    public IaService(IConfiguration config, IHttpClientFactory httpFactory)
    {
        _http = httpFactory.CreateClient();
        _apiKey = config["OpenAI:ApiKey"] ?? throw new ArgumentNullException("OpenAI:ApiKey");
    }

    public async Task<string> AskAsync(string prompt)
    {
        // Segurança: remova dados sensíveis do prompt quando necessário
        var request = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "user", content = prompt }
            },
            max_tokens = 300,
            temperature = 0.2
        };

        var reqJson = JsonSerializer.Serialize(request);
        using var httpReq = new HttpRequestMessage(HttpMethod.Post, "https://api.openai.com/v1/chat/completions");
        httpReq.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        httpReq.Content = new StringContent(reqJson, Encoding.UTF8, "application/json");

        var res = await _http.SendAsync(httpReq);
        res.EnsureSuccessStatusCode();
        var json = await res.Content.ReadAsStringAsync();

        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        // safe navigation: choices[0].message.content
        if (root.TryGetProperty("choices", out var choices) && choices.GetArrayLength() > 0)
        {
            var msg = choices[0].GetProperty("message").GetProperty("content").GetString();
            return msg ?? string.Empty;
        }

        return string.Empty;
    }
}