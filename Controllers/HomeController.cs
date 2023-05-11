using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecto.Models;

namespace TP4_Aboudara_Garbarino_Kalinscky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.dicEquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria() {
        // Tengas que cargar los ViewBags con las listas de cosas
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }

    public IActionResult GuardarIndumentaria (int Equipo, int Media, int Pantalon, int Remera) {
        Indumentaria objetoIndumentaria = new Indumentaria(Equipos.ListaMedias[Media], Equipos.ListaPantalones[Pantalon], Equipos.ListaRemeras[Remera]);
        Equipos.IngresarIndumentaria(Equipos.ListaEquipos[Equipo], objetoIndumentaria);
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
