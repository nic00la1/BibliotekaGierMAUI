using BibliotekaGierMAUI.Models;

namespace BibliotekaGierMAUI
{
    public partial class MainPage : ContentPage
    {
        List<Game> games;
        public MainPage()
        {
            InitializeComponent();

            games = new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Title = "The Witcher 3: Wild Hunt",
                    Description = "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt and based on The Witcher series of fantasy novels by Andrzej Sapkowski. It is the sequel to the 2011 game The Witcher 2: Assassins of Kings and the third main installment in the The Witcher's video game series, played in an open world with a third-person perspective.",
                    ReleaseDate = new DateOnly(2015, 5, 19),
                    Image = "witcher3.jpg",
                    Genres = new string[] { "RPG", "Action", "Adventure" }
                },
                new Game
                {
                    Id = 2,
                    Title = "Cyberpunk 2077",
                    Description = "Cyberpunk 2077 is a 2020 action role-playing video game developed and published by CD Projekt. The story takes place in Night City, an open world set in the Cyberpunk universe. Players assume the first-person perspective of a customisable mercenary known as V, who can acquire skills in hacking and machinery with options for melee and ranged combat.",
                    ReleaseDate = new DateOnly(2020, 12, 10),
                    Image = "cyberpunk2077.jpg",
                    Genres = new string[] { "RPG", "Action", "Adventure" }
                },
                new Game
                {
                    Id = 3,
                    Title = "The Elder Scrolls V: Skyrim",
                    Description = "The Elder Scrolls V: Skyrim is an action role-playing video game developed by Bethesda Game Studios and published by Bethesda Softworks. It is the fifth main installment in The Elder Scrolls series, following The Elder Scrolls IV: Oblivion, and was released worldwide for Microsoft Windows, PlayStation 3, and Xbox 360 on November 11, 2011.",
                    ReleaseDate = new DateOnly(2011, 11, 11),
                    Image = "skyrim.jpg",
                    Genres = new string[] { "RPG", "Action", "Adventure" }
                },
                new Game
                {
                    Id = 4,
                    Title = "Grand Theft Auto V",
                    Description = "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar games.",
                    ReleaseDate = new DateOnly(2013, 9, 17),
                    Image = "gta5.jpg",
                    Genres = new string[] { "Action", "Adventure" }
                },
                new Game
                {
                    Id = 5,
                    Title = "Red Dead Redemption 2",
                    Description = "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and is a prequel to the 2010 game Red Dead Redemption.",
                    ReleaseDate = new DateOnly(2018, 10, 26),
                    Image = "rdr2.jpg",
                    Genres = new string[] { "Action", "Adventure" }
                },
                };
            view.ItemsSource = games; // przypisanie listy gier do widoku
        }
    }

}

