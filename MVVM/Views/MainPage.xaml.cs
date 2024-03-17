using BibliotekaGierMAUI.Services;
using BibliotekaGierMAUI.ViewModels;

namespace BibliotekaGierMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage(IGamesService games)
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel(games);
        }
    }
}

