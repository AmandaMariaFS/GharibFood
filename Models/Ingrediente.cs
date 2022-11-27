namespace GharibFood.Models;

public class Ingrediente
{
    public int Id { get; set; }
    public int Id_receita { get; set; }
    public string Ing { get; set; }

    public Ingrediente(int id, int id_receita, string ing)
    {
        Id_receita = id_receita;
        Id = id;
        Ing = ing;
    }

     public Ingrediente()
    {
        
    } 
}