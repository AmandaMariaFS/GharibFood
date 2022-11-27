namespace GharibFood.Models;

public class Favorito
{
    public int Id { get; set; }
    public int Id_receita { get; set; }
    public string User { get; set; }

    public Favorito(int id, int id_receita, string user)
    {
        Id = id;
        Id_receita = id_receita;
        User = user;
    }

     public Favorito()
    {
        
    } 
}