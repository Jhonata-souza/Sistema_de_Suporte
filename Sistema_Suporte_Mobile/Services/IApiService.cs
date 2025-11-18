using Sistema_Suporte_Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Suporte_Mobile.Services
{
    public interface IApiService
    {
        Task<User> LoginAsync(string email, string password);
        Task<List<Ticket>> GetTicketsAsync(string token);
        Task<Ticket> GetTicketAsync(int id, string token);
        Task<Ticket> CreateTicketAsync(Ticket t, string token);
        Task<bool> UpdateTicketStatusAsync(int ticketId, string status, string token);
    }
}
