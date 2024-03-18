using BibliotekaGierMAUI.MVVM.Models;
using BibliotekaGierMAUI.Services;

namespace BibliotekaGierMAUI.MVVM.ViewModels
{
    public class SectionsViewModel
    {
        public SectionsViewModel(IGamesService games)
        {
            Sections = games.GetCategories();

            // Gdy uzytkownik kliknie na kategorie, przenies go do strony z Grami w tej kategorii
            TappedCommand = new Command<Category>(async (Category category) =>
            {
                var query = new Dictionary<string, object>()
                {
                    { "category", category }
                };
                await Shell.Current.GoToAsync("//sections/category", query);
            });
        }

        public ICollection<Category> Sections { get; set; }
        public Command<Category> TappedCommand { get; }
    }
}
