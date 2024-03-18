using BibliotekaGierMAUI.MVVM.ViewModels;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.Views;

public partial class BookmarksPage : ContentPage
{
    public BookmarksPage(IGamesService games)
    {
        InitializeComponent();
        BindingContext = new BookmarksViewModel(games);
    }
}