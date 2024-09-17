using Microsoft.AspNetCore.Mvc;
using Opgave8x2.Models;

namespace Opgave8x2.Components;

public class VisEnPersonViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(Person p)
    {
        p.Age = 42;
        return View(p);
    }
}