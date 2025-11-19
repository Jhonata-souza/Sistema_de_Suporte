using System.Threading.Tasks;

namespace Sistema_Suporte_Mobile.Services
{
    public interface IIaService
    {
        Task<string> GenerateSummaryAsync(string text);
        Task<string> SuggestReplyAsync(string text);
        Task<string> ClassifyPriorityAsync(string text);
    }
}
