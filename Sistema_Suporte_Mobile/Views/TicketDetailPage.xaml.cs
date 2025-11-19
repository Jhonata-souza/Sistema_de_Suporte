using Sistema_Suporte_Mobile.ViewModels;
using Sistema_Suporte_Mobile.Services;

namespace Sistema_Suporte_Mobile.Views;

public partial class TicketDetailPage : ContentPage
{
    public TicketDetailPage(IApiService api, IIaService ia)
    {
        InitializeComponent();
        BindingContext = new TicketDetailViewModel(api, ia);
    }
}
