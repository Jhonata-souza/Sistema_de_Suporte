using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Animations;
using Sistema_Suporte_Mobile.Models;
using Sistema_Suporte_Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Sistema_Suporte_Mobile.ViewModels
{
    public partial class TicketsViewModel : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
    {
        private readonly IApiService _api;
        private readonly IIaService _ia;
        private readonly string _token;

        public TicketsViewModel(IApiService api, IIaService ia)
        {
            _api = api;
            _ia = ia;
            _token = "mock-token";

            Tickets = new ObservableCollection<Ticket>();
        }

        // Lista visível na UI
        [ObservableProperty]
        private ObservableCollection<Ticket> tickets;

        // Indica loading na View
        [ObservableProperty]
        private bool isBusy;

        // Texto de busca
        [ObservableProperty]
        private string searchQuery;

        // Carrega todos os tickets
        [RelayCommand]
        public async Task LoadTicketsAsync()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var list = await _api.GetTicketsAsync(_token);
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

        // Abre o detalhe de um ticket
        [RelayCommand]
        public async Task OpenDetailsAsync(Ticket ticket)
        {
            if (ticket == null) return;

            await Shell.Current.GoToAsync($"ticketdetails?id={ticket.Id}");
        }

        // Cria novo ticket
        [RelayCommand]
        public async Task CreateTicketAsync()
        {
            await Shell.Current.GoToAsync("newticket");
        }

        // Busca tickets na lista já carregada
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
