using Sistema_Suporte_Mobile.Views;

namespace Sistema_Suporte_Mobile;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("tickets", typeof(TicketsPage));
        Routing.RegisterRoute("ticketDetail", typeof(TicketDetailPage));
        Routing.RegisterRoute("newTicket", typeof(NewTicketPage));
    }
}

