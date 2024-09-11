using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            var person = new Person
            {
                Name = "Rasmus", Age = 24, Birthday = new DateTime(2000, 02, 22)
            };
            
            return View(person);
        }

    }
}
