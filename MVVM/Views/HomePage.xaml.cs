using BibliotekaGierMAUI.Services;
using BibliotekaGierMAUI.ViewModels;

namespace BibliotekaGierMAUI.MVVM.Views;

public partial class HomePage : ContentPage
{
    public HomePage(IGamesService games)
    {
        InitializeComponent();
        this.BindingContext = new HomeViewModel(games);
    }
}