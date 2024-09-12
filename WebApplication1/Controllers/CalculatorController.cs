using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class CalculatorController : Controller
{
    // GET
    
    public IActionResult TimeCalculatorView()
    {
        return View();
    }

    public IActionResult CalculateTime(IFormCollection formcollection)
    {
        int hours = Convert.ToInt32(formcollection["Hours"]);
        int minutes = Convert.ToInt32(formcollection["Minutes"]);
        int seconds = Convert.ToInt32(formcollection["Seconds"]);

        TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
        double total = ts.TotalSeconds;

        ViewBag.hours = hours;
        ViewBag.minutes = minutes;
        ViewBag.seconds = seconds;
        ViewBag.totalInSeconds = total;
        
        return View("TimeCalculatorResult");
    }
}