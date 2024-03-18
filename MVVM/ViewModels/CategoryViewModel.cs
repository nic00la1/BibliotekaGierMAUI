using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.MVVM.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryViewModel(IGamesService games, Category c)
        {
            // Ustaw własciwosci ViewModelu na podstawie sekcji wybranej kategorii
            Name = c.Name;
            Games = games.GetGamesByCategory(c);
        }

        public string? Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
