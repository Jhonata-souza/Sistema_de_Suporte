using Sistema_Suporte_Mobile.ViewModels;

namespace Sistema_Suporte_Mobile.Views;

public partial class TicketDetailPage : ContentPage
{
    public TicketDetailPage(TicketDetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}