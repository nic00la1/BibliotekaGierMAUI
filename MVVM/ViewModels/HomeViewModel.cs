using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel(IGamesService games)
        {
            Tags = games.GetTags();

            PopularGames = games.GetPopularGames();

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

        public ICollection<string> Tags { get; }
        public ICollection<Game> PopularGames { get; set; }
        public Command<Game> TappedCommand { get; set; }
    }
}
