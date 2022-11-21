namespace GharibFood.ViewModels;

public class UsuarioViewModel
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string User { get; set; }
    public string Senha { get; set; }


    public UsuarioViewModel(string nome, string email, string user, string senha)
    {
        Nome = nome;
        Email = email;
        User = user;
        Senha = senha;
    }

     public UsuarioViewModel()
    {
        
    } 
}