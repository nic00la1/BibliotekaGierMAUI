namespace BibliotekaGierMAUI.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string? Image { get; set; }
        public string[]? Genres { get; set; }

    }
}
