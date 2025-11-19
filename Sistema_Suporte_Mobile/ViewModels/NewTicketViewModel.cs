using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sistema_Suporte_Mobile.Models;
using Sistema_Suporte_Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace Sistema_Suporte_Mobile.ViewModels
{
    [QueryProperty(nameof(Token), "token")]
    public partial class NewTicketViewModel : ObservableObject
    {
        private readonly IApiService _api;

        public NewTicketViewModel(IApiService api)
        {
            _api = api;
            Debug.WriteLine(">>> CONSTRUTOR DO NewTicketViewModel FOI CHAMADO <<<");
        }

        private string _token;
        public string Token
        {
            get => _token;
            set
            {
                _token = value;
                //Debug.WriteLine(">>> TOKEN SETADO PELO SHELL NO NewTicketViewModel <<<");
                //Debug.WriteLine($"TOKEN RECEBIDO: {_token}");
            }
        }

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string description;

        [ObservableProperty]
        private string priority;

        [ObservableProperty]
        private bool isBusy;

        [RelayCommand]
        public async Task CreateTicketAsync()
        {
            if (isBusy) return;
            isBusy = true;

            try
            {
                var ticket = new Ticket
                {
                    Title = title,
                    Description = description,
                    Priority = priority,
                    CreatedAt = DateTime.Now
                };

                await _api.CreateTicketAsync(ticket, Token);

                await Shell.Current.DisplayAlert("Sucesso", $"Chamado criado!", "OK");
                Debug.WriteLine($"Chamado criado: {title}");
                //Debug.WriteLine($"TOKEN USADO: {Token}");
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Erro", ex.Message, "OK");
            }
            finally
            {
                isBusy = false;
            }
        }
    }
}
