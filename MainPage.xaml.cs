using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI
{
    public partial class MainPage : ContentPage
    {
        GameModelService gameService;
        public MainPage()
        {
            InitializeComponent();

            gameService = new GameModelService();
            // Pobierasz listę gier z Service
            List<Game> games = gameService.GetGames();

            view.ItemsSource = games; // przypisanie listy gier do widoku
        }
    }
}

