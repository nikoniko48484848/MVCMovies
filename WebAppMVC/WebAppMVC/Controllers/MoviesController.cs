using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers;

public class MoviesController : Controller
{
    private readonly ILogger<MoviesController> _logger;

    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}