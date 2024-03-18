
using BibliotekaGierMAUI.MVVM.Models;
using BibliotekaGierMAUI.MVVM.ViewModels;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.Views;

public partial class CategoryPage : ContentPage, IQueryAttributable
{
    private IGamesService _games;

    public CategoryPage(IGamesService games)
    {
        _games = games;
        InitializeComponent();
    }

    // Jesli uzytkownik wybierze kategorie z listy, to zostanie przekazana do tej metody,
    // ktora ustawia kontekst widoku na nowy obiekt CategoryViewModel
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.FirstOrDefault(c => c.Key.Equals("category")).Value is Category c)
        {
            this.BindingContext = new CategoryViewModel(_games, c);
        }
    }
}