using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using L08WebApplication.Models;

namespace L08WebApplication.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Sale()
    {
        return View();
    }

    public IActionResult MoreSales()
    {
        return View();
    }

    public IActionResult Buy()
    {
        return View();
    }

    public IActionResult BuyAndSell()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}