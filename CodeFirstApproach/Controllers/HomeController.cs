using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Controllers;

public class HomeController : Controller
{
    private readonly EmployeeDBContext employeeDB;

    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    public HomeController(EmployeeDBContext employeeDB)
    {
        this.employeeDB = employeeDB;
    }

    public IActionResult Index()
    {
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

