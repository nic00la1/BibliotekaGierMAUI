using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.MVVM.ViewModels;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.Views;

public partial class GamePage : ContentPage, IQueryAttributable
{
    private readonly IGamesService _games;

    public GamePage(IGamesService games)
    {
        _games = games;
        InitializeComponent();
    }

    // Jesli uzytkownik wybierze gre z listy, to zostanie przekazana do tej metody,
    // ktora ustawia kontekst widoku na nowy obiekt GameViewModel
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.FirstOrDefault(g => g.Key.Equals("game")).Value is Game g)
        {
            this.BindingContext = new GameViewModel(_games, g);
        }
    }
}