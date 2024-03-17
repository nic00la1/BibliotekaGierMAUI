using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(IGamesService games)
        {
            this.LatestGames = games.GetLatestGames();
        }

        public ICollection<Game> LatestGames { get; set; }
    }
}
