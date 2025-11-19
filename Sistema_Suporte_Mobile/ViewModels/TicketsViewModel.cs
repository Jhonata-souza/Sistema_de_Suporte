using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sistema_Suporte_Mobile.Models;
using Sistema_Suporte_Mobile.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Sistema_Suporte_Mobile.ViewModels
{
    [QueryProperty(nameof(Token), "token")]
    public partial class TicketsViewModel : ObservableObject
    {
        private readonly IApiService _api;
        private readonly IIaService _ia;

        private string _token;
        public string Token
        {
            get => _token;
            set
            {
                SetProperty(ref _token, value);

                // Carregar os tickets automaticamente quando o token chegar
                _ = LoadTicketsAsync();
            }
        }

        public TicketsViewModel(IApiService api, IIaService ia)
        {
            _api = api;
            _ia = ia;

            Tickets = new ObservableCollection<Ticket>();
        }

        [ObservableProperty]
        private ObservableCollection<Ticket> tickets;

        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private string searchQuery;

        [RelayCommand]
        public async Task LoadTicketsAsync()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var list = await _api.GetTicketsAsync(Token);
                Tickets.Clear();

                foreach (var t in list)
                    Tickets.Add(t);
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Erro", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        public async Task OpenDetailsAsync(Ticket ticket)
        {
            if (ticket == null) return;

            await Shell.Current.GoToAsync($"ticketDetail?id={ticket.Id}&token={Token}");
        }


        [RelayCommand]
        public async Task CreateTicketAsync()
        {
            await Shell.Current.GoToAsync($"newTicket?token={Token}");
        }

        [RelayCommand]
        public void SearchTickets()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery))
                return;

            var filtered = Tickets
                .Where(t =>
                    t.Title.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase) ||
                    t.Description.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();

            Tickets.Clear();
            foreach (var t in filtered)
                Tickets.Add(t);
        }
    }
}

