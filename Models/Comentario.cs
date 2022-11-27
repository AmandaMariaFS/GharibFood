namespace GharibFood.Models;

public class Comentario
{
    public int Id { get; set; }
    public string User { get; set; }
    public int Id_receita { get; set; }
    public string Coment { get; set; }
    public string Data { get; set; }

    public Comentario(int id, string user, int id_receita, string coment, string data)
    {
        Id_receita = id_receita;
        User = user;
        Id = id;
        Coment = coment;
        Data = data;
    }

     public Comentario()
    {
        
    } 
}