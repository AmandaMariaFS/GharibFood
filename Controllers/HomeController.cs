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
        ViewBag.user = user;
        
        List<Int32> favsIds = new List<Int32>();
        foreach (var favorito in _context.Favoritos)
        {
            if (favorito.User == user)
            {
                favsIds.Add(favorito.Id_receita);
            }
        }

        List<Receita> receitas = new List<Receita>();
        foreach (var id in favsIds)
        {
            receitas.Add(_context.Receitas.Find(id));
        }

        ViewBag.receitasFavs = receitas;
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

    public IActionResult Receita(int id, string user, string comentarios, string avaliacao, string favoritar, int comentarioDel)
    {
        ViewBag.ingredientes = _context.Ingredientes;
        ViewBag.comentarios = _context.Comentarios;
        ViewBag.user = user;

        if (_context.Usuarios.Find(user) != null)
        {
            ViewBag.tipoUser = _context.Usuarios.Find(user).Tipo;
        }
        

        var totalComent = 0;

        if (favoritar == "Nao")
        {
            var idFav = 0;
            foreach (var fav in _context.Favoritos)
            {
                if (fav.Id_receita == id && fav.User == user)
                {
                    idFav = fav.Id;
                }
            }

            _context.Favoritos.Remove(_context.Favoritos.Find(idFav));
            if (_context.Receitas.Find(id).Favoritos > 0)
            {
                _context.Receitas.Find(id).Favoritos = _context.Receitas.Find(id).Favoritos - 1;
            }
            _context.SaveChanges();
        }

        if (favoritar == "Sim")
        {
            var maiorId = 0;
            foreach (var fav in _context.Favoritos)
            {
                if (fav.Id > maiorId)
                {
                    maiorId = fav.Id;
                }
            }
            _context.Favoritos.Add(new Favorito(maiorId + 1, id, user));
            _context.Receitas.Find(id).Favoritos = _context.Receitas.Find(id).Favoritos + 1;
            _context.SaveChanges();
        }

        if (comentarios != null)
        {
            var data = DateTime.Now;
            var totalComentarios = _context.Comentarios.Count();
            _context.Comentarios.Add(new Comentario(totalComentarios + 1, user, id, comentarios, Convert.ToString(data)));
            _context.SaveChanges();
            comentarios = null;
        }

        foreach (var comentario in _context.Comentarios)
        {
            if (comentario.Id_receita == id)
            {
                totalComent++;
            }
        }

        ViewBag.totalComent = totalComent;

        if (avaliacao != null)
        {
            var aval = (_context.Receitas.Find(id).Estrelas + Int16.Parse(avaliacao))/2;
            _context.Receitas.Find(id).Estrelas = aval;
            _context.SaveChanges();
            avaliacao = null;
        }

        ViewBag.favorito = "Nao";

        if (id != null)
        {
            foreach (var fav in _context.Favoritos)
            {
                if (fav.Id_receita == id && fav.User == user)
                {
                    ViewBag.favorito = "Sim";
                }
            }
        }

        if (comentarioDel != 0)
        {
            _context.Comentarios.Remove(_context.Comentarios.Find(comentarioDel));
            _context.SaveChanges();

        }

        return View(_context.Receitas.Find(id));
    }

    public IActionResult CadastroResultado(string user, string nome, string email, string senha)
    {
        _context.Usuarios.Add(new Usuario(user, nome, email, senha, "User"));
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
