using BibliotekaGierMAUI.MVVM.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class SectionsViewModel(IGamesService games)
    {
        public ICollection<Category> Sections { get; set; } = games.GetCategories();
    }
}
