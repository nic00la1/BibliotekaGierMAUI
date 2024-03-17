using BibliotekaGierMAUI.Models;

namespace BibliotekaGierMAUI.Services
{
    public class MockGamesService : IGamesService
    {
        public ICollection<Game> GetLatestGames()
        {
            return new List<Game>()
            {
                new Game(1,
                    "Cyberpunk 2077",
                    "Cyberpunk 2077 to gra RPG akcji osadzona w otwartym świecie, która jest dziełem studia CD Projekt RED, twórców bestsellerowej serii Wiedźmin. Gra została stworzona we współpracy z Mike'em Pondsmithem, autorem gry fabularnej Cyberpunk 2020, na podstawie której powstał tytuł.",
                    new DateOnly(2020, 12, 10),
                    "cyberpunk2077.jpg",
                    "sci-fi",
                    new string[] { "RPG", "FPP", "sci-fi" }),
                new Game(2,
                    "The Witcher 3: Wild Hunt",
                    "The Witcher 3: Wild Hunt to trzecia odsłona popularnej serii gier RPG stworzonych przez polskie studio deweloperskie CD Projekt RED. Tytuł ukazał się na platformach PC, PlayStation 4 i Xbox One w maju 2015 roku.",
                    new DateOnly(2015, 5, 19),
                    "witcher3.jpg",
                    "RPG",
                    new string[] { "RPG", "FPP", "fantasy" }),
                new Game(3,
                    "The Elder Scrolls V: Skyrim",
                    "The Elder Scrolls V: Skyrim to piąta odsłona popularnej serii gier cRPG, stworzona przez Bethesda Softworks. Tytuł ukazał się na platformach PC, PlayStation 3 i Xbox 360 w listopadzie 2011 roku.",
                    new DateOnly(2011, 11, 11),
                    "skyrim.jpg",
                    "fantasy",
                    new string[] { "RPG", "FPP", "fantasy" }),
                new Game(4,
                    "Grand Theft Auto V",
                    "Grand Theft Auto V to piąta odsłona popularnej serii gier akcji, stworzonej przez firmę Rockstar Games. Tytuł ukazał się na platformach PC, PlayStation 3, PlayStation 4, Xbox 360 i Xbox One w wrześniu 2013 roku.",
                     new DateOnly(2013, 9, 17),
                    "gta5.jpg",
                    "cars",
                    new string[] { "TPP", "action", "crime" }),
                new Game(5,
                    "Red Dead Redemption 2",
                    "Red Dead Redemption 2 to druga odsłona popularnej serii gier akcji, stworzonej przez firmę Rockstar Games. Tytuł ukazał się na platformach PC, PlayStation 4 i Xbox One w październiku 2018 roku.",
                    new DateOnly(2018, 10, 26),
                    "rdr2.jpg",
                    "western",
                    new string[] { "TPP", "action", "western" })
            };
        }


    }
}
