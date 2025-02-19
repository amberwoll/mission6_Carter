using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Carter.Models;

namespace Mission6_Carter.Controllers;

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

    public IActionResult GetToKnow()
    {
        return View();
    }
    
    public IActionResult Movies()
    {
        return View();
    }

    
}