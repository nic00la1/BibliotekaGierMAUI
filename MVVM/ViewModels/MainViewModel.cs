using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(IGamesService games)
        {
            this.LatestGames = games.GetLatestGames();

            // Gdy uzytkownik kliknie na gre, przenies go do strony z informacjami o grze
            this.TappedCommand = new Command<Game>((game) =>
            {
                var query = new Dictionary<string, object>()
                {
                    { "game", game }
                };
                Shell.Current.GoToAsync("//home/game", query);
            });
        }

        public ICollection<Game> LatestGames { get; set; }
        public Command<Game> TappedCommand { get; set; }
    }
}
