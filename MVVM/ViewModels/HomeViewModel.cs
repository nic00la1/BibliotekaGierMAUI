using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BibliotekaGierMAUI.ViewModels
{
    public class HomeViewModel
    {
        private readonly IGamesService _gamesService;
        private bool _showAllTags;
        public ObservableCollection<string> Tags { get; } = new ObservableCollection<string>(); // Lista tagów

        public HomeViewModel(IGamesService gamesService)
        {
            _gamesService = gamesService;
            LoadFewTags();

            PopularGames = gamesService.GetPopularGames();
            RecommendedGames = gamesService.GetRecommendedGames();

            // Gdy uzytkownik kliknie na gre, przenies go do strony z informacjami o grze
            TappedCommand = new Command<Game>((game) =>
            {
                var query = new Dictionary<string, object>()
                {
                    { "game", game }
                };
                Shell.Current.GoToAsync("//home/game", query);
            });
        }

        public bool ShowAllTags // Właściwość, która określa, czy pokazać wszystkie tagi
        {
            get => _showAllTags;
            set // Wartość zmienia się, gdy użytkownik kliknie przycisk
            {
                if (_showAllTags != value)
                {
                    _showAllTags = value;
                    if (_showAllTags)
                    {
                        LoadAllTags();
                    }
                    else
                    {
                        LoadFewTags();
                    }
                }
            }
        }

        public ICollection<Game> PopularGames { get; set; }
        public ICollection<Game> RecommendedGames { get; }
        public Command<Game> TappedCommand { get; set; }
        public ICommand ToggleShowAllTagsCommand => new Command(() => ShowAllTags = !ShowAllTags);

        private void LoadFewTags()
        {
            Tags.Clear();
            var fewTags = _gamesService.GetFewTags();
            foreach (var tag in fewTags)
            {
                Tags.Add(tag);
            }
        }

        private void LoadAllTags()
        {
            Tags.Clear();
            var allTags = _gamesService.GetTags();
            foreach (var tag in allTags)
            {
                Tags.Add(tag);
            }
        }


    }
}
