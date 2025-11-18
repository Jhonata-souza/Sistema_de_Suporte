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

namespace Sistema_Suporte_Mobile.ViewModels
{
    public partial class NewTicketViewModel : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
    {
        private readonly IApiService _api;
        private readonly string _token;

        public NewTicketViewModel(IApiService api, string token)
        {
            _api = api;
            _token = token;
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

                await _api.CreateTicketAsync(ticket, _token);

                await Shell.Current.DisplayAlert("Sucesso", "Chamado criado!", "OK");

                await Shell.Current.GoToAsync(".."); // volta para tela anterior
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
