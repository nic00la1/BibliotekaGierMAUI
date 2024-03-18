using BibliotekaGierMAUI.Models;
using BibliotekaGierMAUI.MVVM.Models;
using BibliotekaGierMAUI.MVVM.Views;

namespace BibliotekaGierMAUI.Services
{
    public class MockGamesService : IGamesService
    {
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

        public ICollection<Game> GetLatestGames() =>
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
                    ["TPP", "action", "western"])
            ];


    }
}
