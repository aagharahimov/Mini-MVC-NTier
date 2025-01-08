using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}