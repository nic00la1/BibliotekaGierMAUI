using BibliotekaGierMAUI.MVVM.ViewModels;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.Views;

public partial class SectionsPage : ContentPage
{
    public SectionsPage(IGamesService games)
    {
        InitializeComponent();
        this.BindingContext = new SectionsViewModel(games);
    }
}