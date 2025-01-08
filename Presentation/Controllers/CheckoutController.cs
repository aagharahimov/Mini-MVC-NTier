using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class CheckoutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}