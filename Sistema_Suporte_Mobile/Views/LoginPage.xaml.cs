using Sistema_Suporte_Mobile.Services;
using Sistema_Suporte_Mobile.ViewModels;

namespace Sistema_Suporte_Mobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(IApiService api, LocalDbService local)
    {
        InitializeComponent();
        BindingContext = new LoginViewModel(api, local);
    }
}