using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Carter.Models;

namespace Mission6_Carter.Controllers;

public class HomeController : Controller
{
    private MoviesContext _logger;

    public HomeController(MoviesContext logger)
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
    [HttpGet]
    public IActionResult Movies()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Movies(Movie movie)
    {
        _logger.Movies.Add(movie); //add record to db
        _logger.SaveChanges(); //save changes
        
        return View("Index", movie);
    }
    
}