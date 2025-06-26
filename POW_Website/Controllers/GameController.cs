using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using POWStudio.Models;
using POWStudio.Services;

namespace POWStudio.Controllers;

public class GameController : Controller
{
    private readonly IGameService _gameService;
    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }
    
    [Route("/{slug}")]
    public IActionResult Detail(string slug)
    {
        var game = _gameService.GetBySlug(slug);
        if (game == null)
        {
            return NotFound();
        }

        return View("Detail",game); // trỏ tới Views/Game/Detail.cshtml
    }
}