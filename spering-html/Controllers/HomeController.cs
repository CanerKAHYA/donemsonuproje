using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using spering_html.Models;

namespace spering_html.Controllers;

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

    public IActionResult Category()
    {
        return View();
    }
     public IActionResult Login()
    {
        return View();
    }
public IActionResult About()
    {
        return View();
    }
    public IActionResult Profil()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
