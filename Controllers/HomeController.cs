using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Commandeers.Models;

namespace Commandeers.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveCoordinates([FromBody] Coordinates position)
    {
        GameLogic.X = position.X;
        GameLogic.Y = position.Y;

        return View("Game");
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
