using BibliotekaGierMAUI.Models;

namespace BibliotekaGierMAUI.Helpers
{
    public class GameTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? EvenTemplate { get; set; }
        public DataTemplate? OddTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Game)item).Id % 2 == 0 ? EvenTemplate : OddTemplate;
        }
    }
}
