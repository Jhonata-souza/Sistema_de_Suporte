using Sistema_Suporte_Mobile.ViewModels;

namespace Sistema_Suporte_Mobile.Views;

public partial class NewTicketPage : ContentPage
{
    public NewTicketPage(NewTicketViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}