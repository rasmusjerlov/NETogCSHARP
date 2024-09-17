using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Opgave8x2.Models;

namespace Opgave8x2.Controllers;

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

    public IActionResult VisAlle()
    {
        List<Person> persons = AllePersoner();
        return View(persons);
    }

    public IActionResult VisEn()
    {
        List<Person> persons = AllePersoner();
        return View(persons[0]);
    }

    private List<Person> AllePersoner()
    {
        Person p1 = new Person("Tully", 23);
        Person p2 = new Person("Mikkel", 25);
        Person p3 = new Person("Jens", 27);
        Person p4 = new Person("Mark", 29);
        Person p5 = new Person("Patrick", 25);
        List<Person> persons = new List<Person>();
        persons.Add(p1);
        persons.Add(p2);
        persons.Add(p3);
        persons.Add(p4);
        persons.Add(p5);

        return persons;
    }
    
}