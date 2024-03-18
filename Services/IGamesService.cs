using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.MVVM.Models;

namespace BibliotekaGierMAUI.Services
{
    public interface IGamesService
    {
        public ICollection<string> GetTags();
        public ICollection<Game> GetPopularGames();
        public ICollection<Category> GetCategories();
        public ICollection<Game> GetGamesByCategory(Category category);
    }
}
