using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class BookmarksViewModel
    {
        public BookmarksViewModel(IGamesService gamesService)
        {
            Games = gamesService.GetBookmarkedGames();
        }

        public ICollection<Game> Games { get; set; }
    }
}
