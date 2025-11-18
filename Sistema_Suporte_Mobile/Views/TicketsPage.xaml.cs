using Sistema_Suporte_Mobile.ViewModels;
using Sistema_Suporte_Mobile.Models;

namespace Sistema_Suporte_Mobile.Views;

public partial class TicketsPage : ContentPage
{
    private readonly TicketsViewModel _vm;

    public TicketsPage(TicketsViewModel vm)
    {
        InitializeComponent();
        BindingContext = _vm = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _vm.LoadTicketsCommand.Execute(null);
    }

    private void OnSelect(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Ticket ticket)
        {
            _vm.OpenDetailsCommand.Execute(ticket);
        }
    }
}