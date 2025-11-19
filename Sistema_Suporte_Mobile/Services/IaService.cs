using Sistema_Suporte_Mobile.Models;
using System.Threading.Tasks;

namespace Sistema_Suporte_Mobile.Services
{
    public class IaService : IIaService
    {
        public Task<string> GenerateSummaryAsync(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return Task.FromResult(string.Empty);

            var s = text.Length > 120 ? text.Substring(0, 117) + "..." : text;
            return Task.FromResult($"Resumo: {s}");
        }

        public Task<string> SuggestReplyAsync(string text)
        {
            return Task.FromResult("Verifique se o arquivo não está sendo usado por outro programa. Certifique-se também de que o caminho do arquivo está correto e que o usuário tem permissão de leitura. Se o problema persistir, tente renomear o arquivo e abrir novamente.");
        }

        public Task<string> ClassifyPriorityAsync(string text)
        {
            if (text.Contains("erro") || text.Contains("crash") || text.Contains("falha"))
                return Task.FromResult("Alta");

            return Task.FromResult("Normal");
        }
    }
}
