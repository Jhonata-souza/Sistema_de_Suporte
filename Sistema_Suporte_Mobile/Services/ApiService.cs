using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema_Suporte_Mobile.Models;

namespace Sistema_Suporte_Mobile.Services
{
    internal class ApiService : IApiService
    {
        private readonly List<Ticket> _store = new();
        private int _nextId = 1;


        public ApiService()
        {
            // Dados mock
            _store.Add(new Ticket { Id = _nextId++, UserId = 1, Title = "Erro no sistema", Description = "App fecha ao clicar em X", Priority = "Alta", Status = "Aberto", CreatedAt = DateTime.UtcNow });
        }


        public Task<User> LoginAsync(string email, string password)
        {
            var user = new User { Id = 1, Name = "Usuário Teste", Email = email, Role = email.Contains("admin") ? "Admin" : "User", Token = "mock-token" };
            return Task.FromResult(user);
        }


        public Task<List<Ticket>> GetTicketsAsync(string token)
        {
            return Task.FromResult(_store.ToList());
        }


        public Task<Ticket> GetTicketAsync(int id, string token)
        {
            return Task.FromResult(_store.FirstOrDefault(t => t.Id == id));
        }


        public Task<Ticket> CreateTicketAsync(Ticket t, string token)
        {
            t.Id = _nextId++;
            t.CreatedAt = DateTime.UtcNow;
            t.Status = "Aberto";
            _store.Add(t);
            return Task.FromResult(t);
        }


        public Task<bool> UpdateTicketStatusAsync(int ticketId, string status, string token)
        {
            var t = _store.FirstOrDefault(x => x.Id == ticketId);
            if (t == null) return Task.FromResult(false);
            t.Status = status;
            if (status == "Resolvido") t.ClosedAt = DateTime.UtcNow;
            return Task.FromResult(true);
        }
    }
}
