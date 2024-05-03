using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Controller_2_View_2._0.Models;

namespace Controller_2_View_2._0.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["data1"] = "ViewData Access";
        ViewBag.data2 = "data access by ViewBag";

        TempData["data3"] = "temp data access";
        TempData.Keep();
        return View();
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

