using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Sistema_Suporte_Mobile.Services;
using Sistema_Suporte_Mobile.Models;
using System.Diagnostics;

namespace Sistema_Suporte_Mobile.ViewModels
{
    partial class LoginViewModel : ObservableObject
    {
        private readonly IApiService _api;
        private readonly LocalDbService _local;


        [ObservableProperty]
        string email;


        [ObservableProperty]
        string password;


        public LoginViewModel(IApiService api, LocalDbService local)
        {
            _api = api;
            _local = local;
        }


        [RelayCommand]
        public async Task LoginAsync()
        {
            try
            {
                var user = await _api.LoginAsync(Email, Password);
                await _local.SaveUserAsync(user);
                // Navegar para Tickets
                await Shell.Current.GoToAsync($"/tickets?token={user.Token}");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
