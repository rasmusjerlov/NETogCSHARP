using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class RockbandsController : Controller
{
    // GET
    public IActionResult RockbandsView()
    {
        
        Rockband[] rockbands = new[]
            { new Rockband() { Name = "KISS"},
              new Rockband() { Name = "Deep Purple"},
              new Rockband() { Name = "Credence Clearwater"},
              new Rockband() { Name = "Uriah Heep"},
              new Rockband() { Name = "Queen"},
              new Rockband() { Name = "Rolling Stones"},
              new Rockband() { Name = "Black Sabbath"},
              new Rockband() { Name = "Dire Straights"},
              new Rockband() { Name = "Led Zeppelin"},
              new Rockband() { Name = "AC/DC"}
            };
        
        return View(rockbands);
    }
}