using SQLite;
using Sistema_Suporte_Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema_Suporte_Mobile.Services
{
    public class LocalDbService
    {
        private readonly SQLiteAsyncConnection _db;

        public LocalDbService(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<User>().Wait();
            _db.CreateTableAsync<Ticket>().Wait();
            _db.CreateTableAsync<Comment>().Wait();
        }

        public Task<List<Ticket>> GetCachedTicketsAsync() => _db.Table<Ticket>().ToListAsync();
        public Task<int> SaveTicketAsync(Ticket t) => _db.InsertOrReplaceAsync(t);
        public Task<int> SaveUserAsync(User u) => _db.InsertOrReplaceAsync(u);
        public Task<User> GetUserAsync() => _db.Table<User>().FirstOrDefaultAsync();
    }
}
