using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}