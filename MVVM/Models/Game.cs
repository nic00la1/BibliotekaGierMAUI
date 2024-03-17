namespace BibliotekaGierMAUI.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string? Image { get; set; }
        public string? Category { get; set; }
        public string[]? Genres { get; set; }

        public Game(int id, string title, string description, DateOnly releaseDate, string image, string category, string[] genres)
        {
            Id = id;
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            Image = image;
            Category = category;
            Genres = genres;
        }
    }
}
