using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaCadastroContatos.Models;

namespace SistemaCadastroContatos.Controllers;

public class HomeController : Controller
{
    // pega a Home e inicia por padrão (pagina inicial)
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
