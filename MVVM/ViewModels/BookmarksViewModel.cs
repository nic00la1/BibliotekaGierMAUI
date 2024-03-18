using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class BookmarksViewModel
    {
        public BookmarksViewModel(IGamesService gamesService)
        {
            Games = gamesService.GetBookmarkedGames();

            TappedCommand = new Command<Game>((game) =>
            {
                var query = new Dictionary<string, object>()
                {
                    { "game", game }
                };
                Shell.Current.GoToAsync("//bookmarks/game", query);
            });
        }

        public ICollection<Game> Games { get; set; }
        public Command TappedCommand { get; set; }
    }
}
