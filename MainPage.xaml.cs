using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI
{
    public partial class MainPage : ContentPage
    {
        private GameModelService gameService; // deklaracja serwisu do pobierania gier, itp.
        private TagsService tagsService; // deklaracja serwisu do pobierania tagów

        public MainPage()
        {
            InitializeComponent();

            // Inicjalizacja serwisów
            gameService = new GameModelService();
            tagsService = new TagsService();

            // Pobranie listy gier i tagów
            List<Game> games = gameService.GetGames();
            List<string> tags = tagsService.GetTags().ToList();

            // Przypisanie do widoku
            view.ItemsSource = games; // przypisanie listy gier do widoku
            tagsListView.ItemsSource = tags; // przypisanie listy tagów do widoku


        }
    }
}

