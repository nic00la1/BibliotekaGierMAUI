using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.MVVM.Models;
using BibliotekaGierMAUI.MVVM.Views;

namespace BibliotekaGierMAUI.Services
{
    public class MockGamesService : IGamesService
    {
        private ICollection<Game> _games; // Kolekcja gier

        public MockGamesService() // Konstruktor 
        {
            _games = GetPopularGames();
        }

        public ICollection<string> GetTags()
        {
            return new List<string>
            {
                "RPG",
                "FPP",
                "TPP",
                "fantasy",
                "sci-fi",
                "western",
                "action",
                "crime",
                "cars",
                "historical",
                "modern",
                "sandbox",
                "simulation",
                "battle royale",
                "MOBA",
                "strategy",
                "action-adventure",
                "adventure"
            };
        }

        public ICollection<string> GetFewTags()
        {
            return GetTags().Take(5).ToList();
        }

        // Uzywam tego do kategorii, ktore wyswietlaja sie w SectionsPage
        public ICollection<Category> GetCategories() =>
            [
                new("RPG", MaterialDesignIcons.LocalAtm),
                    new("FPP", MaterialDesignIcons.Camera),
                    new("TPP", MaterialDesignIcons.LiveTv),
                    new("fantasy", MaterialDesignIcons.LocalPharmacy),
                    new("sci-fi", MaterialDesignIcons.LocalPizza),
                    new("western", MaterialDesignIcons.LocalBar),
                    new("action", MaterialDesignIcons.LocalMovies),
                    new("crime", MaterialDesignIcons.Portrait)
            ];

        public ICollection<Game> GetPopularGames() =>
            [
                new (1,
                        "Cyberpunk 2077",
                        "Cyberpunk 2077 to gra RPG akcji osadzona w otwartym świecie, która jest dziełem studia CD Projekt RED, twórców bestsellerowej serii Wiedźmin. Gra została stworzona we współpracy z Mike'em Pondsmithem, autorem gry fabularnej Cyberpunk 2020, na podstawie której powstał tytuł.",
                        new DateOnly(2020, 12, 10),
                        "cyberpunk2077.jpg",
                        "sci-fi",
                        ["RPG", "FPP", "sci-fi"]),
                    new (2,
                        "The Witcher 3: Wild Hunt",
                        "The Witcher 3: Wild Hunt to trzecia odsłona popularnej serii gier RPG stworzonych przez polskie studio deweloperskie CD Projekt RED. Tytuł ukazał się na platformach PC, PlayStation 4 i Xbox One w maju 2015 roku.",
                        new DateOnly(2015, 5, 19),
                        "witcher3.jpg",
                        "RPG",
                        ["RPG", "FPP", "fantasy"]),
                    new (3,
                        "The Elder Scrolls V: Skyrim",
                        "The Elder Scrolls V: Skyrim to piąta odsłona popularnej serii gier cRPG, stworzona przez Bethesda Softworks. Tytuł ukazał się na platformach PC, PlayStation 3 i Xbox 360 w listopadzie 2011 roku.",
                        new DateOnly(2011, 11, 11),
                        "skyrim.jpg",
                        "fantasy",
                        ["RPG", "FPP", "fantasy"]),
                    new (4,
                        "Grand Theft Auto V",
                        "Grand Theft Auto V to piąta odsłona popularnej serii gier akcji, stworzonej przez firmę Rockstar Games. Tytuł ukazał się na platformach PC, PlayStation 3, PlayStation 4, Xbox 360 i Xbox One w wrześniu 2013 roku.",
                        new DateOnly(2013, 9, 17),
                        "gta5.jpg",
                        "cars",
                        ["TPP", "action", "crime"]),
                    new (5,
                        "Red Dead Redemption 2",
                        "Red Dead Redemption 2 to druga odsłona popularnej serii gier akcji, stworzonej przez firmę Rockstar Games. Tytuł ukazał się na platformach PC, PlayStation 4 i Xbox One w październiku 2018 roku.",
                        new DateOnly(2018, 10, 26),
                        "rdr2.jpg",
                        "western",
                        ["TPP", "action", "western"]),
                    new (6,
                        "Assassin's Creed Valhalla",
                        "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal and published by Ubisoft. It is the twelfth major installment and the twenty-second release in the Assassin's Creed series, and a successor to the 2018 game Assassin's Creed Odyssey.",
                        new DateOnly(2020, 11, 10),
                        "acvalhalla.jpg",
                        "historical",
                        ["TPP", "action", "historical"]),
                    new (7,
                        "Call of Duty: Warzone",
                        "Call of Duty: Warzone is a free-to-play battle royale video game released on March 10, 2020, for PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, and Microsoft Windows. The game is a part of the 2019 title Call of Duty: Modern Warfare, but does not require purchase of it.",
                        new DateOnly(2020, 3, 10),
                        "codwarzone.jpg",
                        "modern",
                        ["TPP", "action", "modern"]),
                    new (8,
                        "Minecraft",
                        "Minecraft is a sandbox video game developed by Mojang Studios. It was created by Markus Persson in the Java programming language and released as a public alpha for personal computers in 2009 before officially releasing in November 2011, with Jens Bergensten taking over development.",
                        new DateOnly(2011, 11, 18),
                        "minecraft.jpg",
                        "sandbox",
                        ["TPP", "adventure", "sandbox"]),
                    new (9,
                        "Sims 4",
                        "The Sims 4 is a life simulation video game developed by the Redwood Shores studio of Maxis and published by Electronic Arts. It is the fourth major title in The Sims series and was originally announced on May 6, 2013. It was released in North America on September 2, 2014, for Microsoft Windows.",
                        new DateOnly(2014, 9, 2),
                        "sims4.jpg",
                        "simulation",
                        ["TPP", "simulation"]),
                    new (10,
                        "Fortnite",
                        "Fortnite is an online video game developed by Epic Games and released in 2017. It is available in three distinct game mode versions that otherwise share the same general gameplay and game engine: Fortnite: Save the World, a cooperative hybrid-tower defense-shooter-survival game for up to four players to fight off zombie-like creatures and defend objects with traps and fortifications they can build; Fortnite Battle Royale, a free-to-play battle royale game in which up to 100 players fight to be the last person standing; and Fortnite Creative, in which players are given complete freedom to create worlds and battle arenas.",
                        new DateOnly(2017, 7, 25),
                        "fortnite.jpeg",
                        "battle royale",
                        ["TPP", "action", "battle royale"]),
                    new (11,
                        "Dota 2",
                        "Dota 2 is a multiplayer online battle arena (MOBA) video game developed and published by Valve. The game is a sequel to Defense of the Ancients (DotA), which was a community-created mod for Blizzard Entertainment's Warcraft III: Reign of Chaos and its expansion pack, The Frozen Throne. Dota 2 is played in matches between two teams of five players, with each team occupying and defending their own separate base on the map.",
                        new DateOnly(2013, 7, 9),
                        "dota2.jpg",
                        "MOBA",
                        ["TPP", "strategy", "MOBA"]),
                    new (12,
                        "League of Legends",
                        "League of Legends is a multiplayer online battle arena (MOBA) video game developed and published by Riot Games. The game follows a freemium model and is supported by microtransactions, and was inspired by the Warcraft III: The Frozen Throne mod, Defense of the Ancients. In League of Legends, players assume the role of a 'champion' with unique abilities and battle against a team of other players or computer-controlled champions.",
                        new DateOnly(2009, 10, 27),
                        "lol.jpg",
                        "MOBA",
                        ["TPP", "strategy", "MOBA"]),
                    new (13,
                        "The Last of Us Part II",
                        "The Last of Us Part II is an action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment. It is the sequel to The Last of Us (2013) and was released for the PlayStation 4 in June 2020. The game is set in a post-apocalyptic United States, five years after the events of the first game, and follows Ellie as she seeks revenge against a mysterious cult in a quest for justice.",
                        new DateOnly(2020, 6, 19),
                        "tlou2.jpg",
                        "action-adventure",
                        ["TPP", "action", "adventure"])
            ];

        public ICollection<Game> GetGamesByCategory(Category category)
        {
            // Zwróć gry, które należą do danej kategorii
            return _games.Where(game => game.Genres.Contains(category.Name)).ToList();
        }

    }
}
