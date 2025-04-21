using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_Tanel_Dobrovitzky.Models;

namespace TP03_Tanel_Dobrovitzky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Dictionary<int, Integrante> integrantes = Grupo.InicializarGrupo();
        ViewBag.integrantes = integrantes;
        return View();
    }
    public IActionResult SelectIntegrante(int dni)
    {
        Dictionary<int, Integrante> integrantes = new Dictionary<int, Integrante>();
        ViewBag.integrante = Grupo.DevolverIntegranteDni(dni);
        return View("MostrarDatosPersonales");
    }
    public IActionResult MostrarDatosFamiliares(int dni)
    {
        Dictionary<int, Integrante> integrantes = new Dictionary<int, Integrante>();
        ViewBag.integrante = Grupo.DevolverIntegranteDni(dni);
        return View("infoDatosFamiliares");
    }
    public IActionResult MostrarDatosInteres(int dni)
    {
        Dictionary<int, Integrante> integrantes = new Dictionary<int, Integrante>();
        ViewBag.integrante = Grupo.DevolverIntegranteDni(dni);
        return View("DatoInteres");
    }
}
