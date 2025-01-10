using Microsoft.AspNetCore.Mvc;

namespace W14_Jwt.Controllers;

public class AuthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}