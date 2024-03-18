using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.MVVM.Models;

namespace BibliotekaGierMAUI.Services
{
    public interface IGamesService
    {
        public ICollection<string> GetTags();
        public ICollection<string> GetFewTags();
        public ICollection<Category> GetCategories();
        public ICollection<Game> GetPopularGames();
        public ICollection<Game> GetRecommendedGames();
        public ICollection<Game> GetBookmarkedGames();
        public ICollection<Game> GetGamesByCategory(Category category);
    }
}
