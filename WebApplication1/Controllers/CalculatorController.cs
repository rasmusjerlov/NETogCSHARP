using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult TimeCalculator()
    {
        return View();
    }
}