using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App2.Models;

namespace App2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (User.Claims.Select(c => c.Type).Contains("extension_Game"))
        {
            return View();
        }
        return Redirect("/MicrosoftIdentity/Account/EditProfile");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
