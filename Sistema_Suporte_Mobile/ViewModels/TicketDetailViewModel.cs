using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    public partial class TicketDetailViewModel : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
    {
        private readonly IApiService _api;
        private readonly IIaService _ia;
        private readonly string _token;

        public TicketDetailViewModel(IApiService api, IIaService ia, string token)
        {
            _api = api;
            _ia = ia;
            _token = token;
        }

        [ObservableProperty]
        private Ticket ticket;

        [ObservableProperty]
        private string newComment;

        [ObservableProperty]
        private bool isBusy;

        public async void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("id"))
            {
                int id = int.Parse(query["id"].ToString());
                await LoadTicketAsync(id);
            }
        }

        [RelayCommand]
        public async Task LoadTicketAsync(int id)
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                Ticket = await _api.GetTicketAsync(id, _token);
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
        public async Task GenerateAiSummaryAsync()
        {
            if (Ticket == null) return;

            Ticket.AiSummary = await _ia.GenerateSummaryAsync(Ticket.Description);

            await Shell.Current.DisplayAlert("IA", "Resumo gerado!", "OK");
        }

        [RelayCommand]
        public async Task AddCommentAsync()
        {
            if (string.IsNullOrWhiteSpace(NewComment)) return;

            await Shell.Current.DisplayAlert("Erro", "Função de adicionar comentário não implementada no serviço de API.", "OK");

            NewComment = string.Empty;

            await LoadTicketAsync(Ticket.Id);
        }
    }
}
