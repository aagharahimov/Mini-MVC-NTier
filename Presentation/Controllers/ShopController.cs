using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class ShopController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}