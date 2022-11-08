using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GharibFood.Models;
using GharibFood.ViewModels;

namespace GharibFood.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static List<ReceitaViewModel> receitas = 
        new List<ReceitaViewModel>{
        new ReceitaViewModel(1, "Arroz negro à brasileira", "../imagens/arroznegro.jpg", "imagem de arroz negro à brasileira", "Salgado", "America", "https://www.youtube.com/embed/diKgUdmj0m8", "10 min", "2 porções", 0, 0),
            new ReceitaViewModel(2, "Tartar de salmão, manga e avocado", "../imagens/tartar.jpg", "imagem de tartar de salmão, manga e avocado", "Salgado", "Africa", "https://youtu.be/OhiMLGrulKk", "10 min", "2 porções", 0, 0),
            new ReceitaViewModel(3, "Torta de abóbora de noz e pecã", "../imagens/torta-abobora-nozes.png", "imagem de torta de abóbora de noz e pecã", "Doce", "Asia", "https://youtu.be/Pv6qx9nnBHg", "10 min", "2 porções", 0, 0),
            new ReceitaViewModel(4, "Dakos", "../imagens/dakos.png", "imagem de dakos", "Salgado", "Europa", "https://youtu.be/fzBkeChLJL8", "10 min", "2 porções", 0, 0)
        };

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(receitas);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Perfil()
    {
        return View();
    }

    public IActionResult Salgado(string continente)
    {
        ViewBag.continente = continente;
        return View(receitas);
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Doce(string continente)
    {
        ViewBag.continente = continente;
        return View(receitas);
    }

    public IActionResult Search(string textBusca)
    {
        ViewBag.textBusca = textBusca;
        return View(receitas);
    }

    public IActionResult Receita(int id)
    {
        return View(receitas[id-1]);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
