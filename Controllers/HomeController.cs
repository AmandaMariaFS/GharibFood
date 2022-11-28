using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GharibFood.Models;

namespace GharibFood.Controllers;

public class HomeController : Controller
{
    private readonly GharibFoodContext _context;

    public HomeController(GharibFoodContext context)
    {
        _context = context;
    }

    public IActionResult Index(string user)
    {   
        ViewBag.user = user;
        return View(_context.Receitas);
    }

    public IActionResult Privacy(string user)
    {
        ViewBag.user = user;
        return View();
    }

    public IActionResult Perfil(string user)
    {
        return View(_context.Usuarios.Find(user));
    }

    public IActionResult Salgado(string continente, string user)
    {
        ViewBag.continente = continente;
        ViewBag.user = user;
        return View(_context.Receitas);
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
        return View(_context.Receitas);
    }

    public IActionResult Search(string textBusca, string user)
    {
        ViewBag.textBusca = textBusca;
        ViewBag.user = user;
        return View(_context.Receitas);
    }

    public IActionResult Receita(int id, string user)
    {
        ViewBag.ingredientes = _context.Ingredientes;
        ViewBag.comentarios = _context.Comentarios;
        ViewBag.user = user;
        return View(_context.Receitas.Find(id));
    }

    public IActionResult CadastroResultado(string user, string nome, string email, string senha, string foto)
    {
        foto = "../imagens/perfil.png";
        _context.Usuarios.Add(new Usuario(user, nome, email, senha, foto));
        _context.SaveChanges();
        ViewBag.user = user;
        return View();
    }

    public IActionResult LoginResultado(string email, string senha)
    {
        Usuario user = new Usuario();
        foreach (var usuario in _context.Usuarios)
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
