using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.MVVM.Models;

namespace BibliotekaGierMAUI.Services
{
    public interface IGamesService
    {
        public ICollection<Game> GetLatestGames();
        public ICollection<Category> GetCategories();
    }
}
