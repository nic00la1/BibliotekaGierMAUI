using BibliotekaGierMAUI.Models;

namespace BibliotekaGierMAUI.Services
{
    public interface IGamesService
    {
        public ICollection<Game> GetLatestGames();
    }
}
