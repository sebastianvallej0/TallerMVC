using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Taller_LigaPro.Models;

namespace Taller_LigaPro.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger; // verificamos el contructor y no voy a hacer ningun cambio ya que esta todo correcto 

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    // aqui podemos ver todos los metodos que tenemos

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
