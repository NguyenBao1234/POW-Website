using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using POWStudio.Models;

namespace POWStudio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var games = new List<Game>
        {
            new Game
            {
                Title = "BEDOSO MONSTER",
                Description = "A dark survival horror game.",
                TittleImageUrl = "/Image/Logo/BedosoMonsterTitleWhite.png",
                BgImageUrl = "/Image/ArtworkGame/BedosoMonsterBG.jpg",
                StoreLink = "https://store.steampowered.com/app/xxxxxx"
            },
            new Game
            {
                Title = "HorrorSerum",
                TittleImageUrl = "/Image/Logo/HorrorSerumTitle.png",
                Description = "A dark survival horror game.",
                BgImageUrl = "/Image/ArtworkGame/HorrorSerumArtwork.jpg",
                StoreLink = "https://store.steampowered.com/app/xxxxxx"
            },
            new Game
            {
                Title = "Bad of Green Thorn",
                Description = "Puzzle-based psychological thriller.",
                BgImageUrl = "/Image/ArtworkGame/BadOfGreenThorn capture.jpg",
                StoreLink = "https://store.steampowered.com/app/yyyyyy"
            },
            new Game
            {
                Title = "InteractivePaper",
                Description = "Tool for interactive paper game.",
                BgImageUrl = "/Image/ArtworkGame/PaperInteractive16div9.png",
                StoreLink = "https://store.steampowered.com/app/xxxxxx"
            }
        };

        return View(games);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}