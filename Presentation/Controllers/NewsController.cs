using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class NewsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}