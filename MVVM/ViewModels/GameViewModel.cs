using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class GameViewModel
    {
        public GameViewModel(IGamesService games, Game g)
        {
            this.Title = g.Title;
            this.Description = g.Description;
            this.Image = g.Image;
            this.ReleaseDate = g.ReleaseDate;
            this.Genres = g.Genres;
        }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string[]? Genres { get; set; }

    }
}
