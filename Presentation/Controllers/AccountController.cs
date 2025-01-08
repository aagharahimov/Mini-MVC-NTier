using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}