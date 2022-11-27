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
            new ReceitaViewModel(2, "Tartar de salmão, manga e avocado", "../imagens/tartar.jpg", "imagem de tartar de salmão, manga e avocado", "Salgado", "Africa", "https://www.youtube.com/embed/OhiMLGrulKk", "50 min", "3 porções", 0, 0),
            new ReceitaViewModel(3, "Torta de abóbora de noz e pecã", "../imagens/torta-abobora-nozes.png", "imagem de torta de abóbora de noz e pecã", "Doce", "Asia", "https://www.youtube.com/embed/Pv6qx9nnBHg", "60 min", "6 porções", 0, 0),
            new ReceitaViewModel(4, "Dakos", "../imagens/dakos.png", "imagem de dakos", "Salgado", "Europa", "https://www.youtube.com/embed/fzBkeChLJL8", "30 min", "2 porções", 0, 0)
        };

    private static List<UsuarioViewModel> usuarios = new List<UsuarioViewModel>{
        new UsuarioViewModel("Amanda", "amandinhaferre@hotmail.com", "AmandaMariaFS", "EnolaHolmes")
    };

    bool cadastrado = false;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string user)
    {   
        ViewBag.user = user;
        return View(receitas);
    }

    public IActionResult Privacy(string user)
    {
        ViewBag.user = user;
        return View();
    }

    public IActionResult Perfil(string user)
    {
        foreach (var usuario in usuarios)
        {
            if (usuario.User == user)
            {
                ViewBag.user = user;
                ViewBag.nome = usuario.Nome;
                ViewBag.email = usuario.Email;
            }
        }
        return View();
    }

    public IActionResult Salgado(string continente, string user)
    {
        ViewBag.continente = continente;
        ViewBag.user = user;
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

    public IActionResult Doce(string continente, string user)
    {
        ViewBag.continente = continente;
        ViewBag.user = user;
        return View(receitas);
    }

    public IActionResult Search(string textBusca, string user)
    {
        ViewBag.textBusca = textBusca;
        ViewBag.user = user;
        return View(receitas);
    }

    public IActionResult Receita(int id, string user)
    {
        ViewBag.id = id;
        ViewBag.user = user;
        return View(receitas);
    }

    public IActionResult CadastroResultado(string nome, string email, string nomeusuario, string senha)
    {
        usuarios.Add(new UsuarioViewModel(nome, email, nomeusuario, senha));
        ViewBag.user = nomeusuario;
        return View();
    }

    public IActionResult LoginResultado(string email, string senha)
    {
        UsuarioViewModel user = new UsuarioViewModel();
        foreach (var usuario in usuarios)
        {
            if (usuario.Email == email && usuario.Senha == senha)
            {
                user = usuario;
            }
        }

        return View(user);
    } 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Comentar()
    {
        return View();
    }
}
