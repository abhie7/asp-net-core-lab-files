using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers;

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
    public IActionResult Index(Student student)
    {
        if (ModelState.IsValid)
        {
            return View("Index", student);
            //return "Enrollment No: " + student.EnrollmentNo +
            //   "\nName: " + student.Name +
            //   "\nAddress: "+ student.Address +
            //   "\nEmail: " + student.Email +
            //   "\nMobile: " + student.Mobile +
            //   "\nGender: " + student.Gender +
            //   "\nHobby: " + student.Hobby +
            //   "\nCity: " + student.City;
        }
        return View(student);
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