using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class GameViewModel
    {
        public GameViewModel(IGamesService games, Game game)
        {
            this.Title = game.Title;
            this.Description = game.Description;
            this.Image = game.Image;
            this.ReleaseDate = game.ReleaseDate;
        }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
