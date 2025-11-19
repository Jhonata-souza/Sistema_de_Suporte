using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sistema_Suporte_Mobile.Models;
using Sistema_Suporte_Mobile.Services;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Sistema_Suporte_Mobile.ViewModels
{
    [QueryProperty(nameof(TicketId), "id")]
    [QueryProperty(nameof(Token), "token")]
    public partial class TicketDetailViewModel : ObservableObject
    {
        private readonly IApiService _api;
        private readonly IIaService _ia;

        public TicketDetailViewModel(IApiService api, IIaService ia)
        {
            _api = api;
            _ia = ia;

            // Inicializa o ticket para evitar nulos
            Ticket = new Ticket();
        }

        private int _ticketId;
        public int TicketId
        {
            get => _ticketId;
            set
            {
                SetProperty(ref _ticketId, value);
                _ = LoadTicketAsync();
            }
        }

        private string _token;
        public string Token
        {
            get => _token;
            set => SetProperty(ref _token, value);
        }

        [ObservableProperty]
        private Ticket ticket;

        [ObservableProperty]
        private bool isBusy;

        // Comando para carregar ticket
        [RelayCommand]
        public async Task LoadTicketAsync()
        {
            IsBusy = true;
            try
            {
                if (TicketId > 0)
                {
                    var t = await _api.GetTicketAsync(TicketId, Token);
                    Ticket = t ?? new Ticket();
                }
                else
                {
                    Ticket = new Ticket(); // novo ticket
                }

                // Notifica que os comandos podem atualizar IsEnabled
                OnPropertyChanged(nameof(Ticket));
            }
            finally
            {
                IsBusy = false;
            }
        }

        // Comando para salvar ticket
        [RelayCommand]
        public async Task SaveTicketAsync()
        {
            if (string.IsNullOrWhiteSpace(Ticket.Title) || string.IsNullOrWhiteSpace(Ticket.Description))
            {
                //await Shell.Current.DisplayAlert("Erro", "Título e descrição são obrigatórios!", "OK");
                return;
            }

            IsBusy = true;
            try
            {
                if (Ticket.Id == 0) // Novo ticket
                {
                    Ticket.Status = "Aberto";
                    Ticket.CreatedAt = new DateTime(2025, 11, 18, 14, 30, 0);
                    Ticket.UserId = 1; // mock usuário logado

                    var criado = await _api.CreateTicketAsync(Ticket, Token);
                    Ticket = criado;

                    await Shell.Current.DisplayAlert("Sucesso", "Ticket criado!", "OK");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Info", "Ticket já existe!", "OK");
                }

                // Atualiza bindings para habilitar botões IA
                OnPropertyChanged(nameof(Ticket));
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        public async Task GenerateAiSummaryAsync()
        {
            if (Ticket == null || string.IsNullOrWhiteSpace(Ticket.Description)) return;

            Ticket.AiSummary = await _ia.GenerateSummaryAsync(Ticket.Description);
            OnPropertyChanged(nameof(Ticket));
        }

        [RelayCommand]
        public async Task GenerateAiResponseAsync()
        {
            if (Ticket == null || string.IsNullOrWhiteSpace(Ticket.Description)) return;

            Ticket.AiResponse = await _ia.SuggestReplyAsync(Ticket.Description);
            OnPropertyChanged(nameof(Ticket));
        }
    }
}