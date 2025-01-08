using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class BasketController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}