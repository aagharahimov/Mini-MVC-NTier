using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class PaymentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}