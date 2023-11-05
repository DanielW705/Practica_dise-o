using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using primera_pagina_web.Models;

namespace primera_pagina_web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly TiendaContext _BB;
    public HomeController(ILogger<HomeController> logger, TiendaContext bb)
    {
        _logger = logger;
        _BB = bb;
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

    [HttpGet]
    public IActionResult Log_in()
    {
        return PartialView("_LogIn");
    }

    [HttpGet]
    public IActionResult LogIn(Usuario usuario_login)
    {
        if (!ModelState.IsValid)
            return Json("Sin datos");
        else
            return Json("Salio bien");
    }
}
