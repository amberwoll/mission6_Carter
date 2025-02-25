using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Carter.Models;
using Microsoft.EntityFrameworkCore;
namespace Mission6_Carter.Controllers;


public class HomeController : Controller
{
    private MoviesContext _context;

    public HomeController(MoviesContext context)
    {
        _context = context;
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
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName).ToList();
        return View("Movies", new Movie());
    }

    [HttpPost]
    public IActionResult Movies(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(movie); //add record to db
            _context.SaveChanges(); //save changes
        
            return View("Index", movie);
        }
        else
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();
            return View("Movies", movie);
        }
    }
    
    public IActionResult ViewMovies()
    {
        //Linq
        var movies = _context.Movies
            .Include(x => x.Category)
            .OrderBy(x => x.Title).ToList();
        return View(movies);
    }
}
