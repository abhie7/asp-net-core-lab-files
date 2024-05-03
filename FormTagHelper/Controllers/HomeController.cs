using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormTagHelper.Models;

namespace FormTagHelper.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]

    public string Index(Employee e1)
    {
        return "Name: " + e1.Ename + "\nAge: " + e1.Age + "\nGender: " + e1.Gender + "\nMstatus: " + e1.Mstatus + "\nDescription:" + e1.Description;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

