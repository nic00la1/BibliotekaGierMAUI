namespace BibliotekaGierMAUI.MVVM.Models
{
    public class Category(string name, string materialIcon)
    {
        public string? Name { get; set; } = name;
        public string? MaterialIcon { get; set; } = materialIcon;
    }
}
