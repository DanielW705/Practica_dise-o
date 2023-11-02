using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using primera_pagina_web.Models;

namespace primera_pagina_web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly TiendaContext _BB;
    public HomeController(ILogger<HomeController> logger,TiendaContext bb)
    {
        _logger = logger;
        _BB = bb;
    }

    public IActionResult Index()
    {
        List<Administrador> administradores = _BB.Administradors.ToList();
        return View(administradores);
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
