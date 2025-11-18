using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Suporte_Mobile.Models;

namespace Sistema_Suporte_Mobile.Services
{
    public class IaService : IIaService
    {
        // Mock: simplificações para desenvolvimento offline
        public Task<string> GenerateSummaryAsync(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return Task.FromResult(string.Empty);
            var s = text.Length > 120 ? text.Substring(0, 117) + "..." : text;
            return Task.FromResult($"Resumo: {s}");
        }


        public Task<string> SuggestReplyAsync(string text)
        {
            return Task.FromResult("Olá, obrigado pelo relato. Estamos analisando e retornaremos em breve.");
        }


        public Task<string> ClassifyPriorityAsync(string text)
        {
            if (text.Contains("erro") || text.Contains("crash") || text.Contains("falha")) return Task.FromResult("Alta");
            return Task.FromResult("Normal");
        }
    }
}
