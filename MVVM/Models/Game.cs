namespace BibliotekaGierMAUI.Models
{
    public class Game(int id, string title, string description, DateOnly releaseDate, string image, string category, string[] genres)
    {
        public int Id { get; set; } = id;
        public string? Title { get; set; } = title;
        public string? Description { get; set; } = description;
        public DateOnly ReleaseDate { get; set; } = releaseDate;
        public string? Image { get; set; } = image;
        public string? Category { get; set; } = category;
        public string[]? Genres { get; set; } = genres;
    }
}
