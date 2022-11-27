namespace GharibFood.Models;

public class Usuario
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Foto { get; set; }


    public Usuario(string id, string nome, string email, string senha, string foto)
    {
        Nome = nome;
        Email = email;
        Id = id;
        Senha = senha;
        Foto = foto;
    }

     public Usuario()
    {
        
    } 
}