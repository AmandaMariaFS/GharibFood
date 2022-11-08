namespace GharibFood.ViewModels;

public class UsuarioViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string User { get; set; }
    public string Senha { get; set; }


    public UsuarioViewModel(int id, string nome, string email, string user, string senha)
    {
        Id = id;
        Nome = nome;
        Email = email;
        User = user;
        Senha = senha;
    }
}