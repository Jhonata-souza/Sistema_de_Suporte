using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Suporte_Mobile.Models;

namespace Sistema_Suporte_Mobile.Services
{
    public interface IIaService
    {
        Task<string> GenerateSummaryAsync(string text);
        Task<string> SuggestReplyAsync(string text);
        Task<string> ClassifyPriorityAsync(string text);
    }
}
