using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class GameViewModel(IGamesService games, Game g)
    {
        public string? Title { get; set; } = g.Title;
        public string? Description { get; set; } = g.Description;
        public string? Image { get; set; } = g.Image;
        public DateOnly ReleaseDate { get; set; } = g.ReleaseDate;
        public string[]? Genres { get; set; } = g.Genres;
    }
}
