namespace GharibFood.ViewModels;

public class ReceitaViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CaminhoFoto { get; set; }
    public string DescAlt { get; set; }
    public string Categoria { get; set; }
    public string Continente { get; set; }

    public ReceitaViewModel(int id, string nome, string caminhoFoto, string descAlt, string categoria, string continente)
    {
        Id = id;
        Nome = nome;
        CaminhoFoto = caminhoFoto;
        DescAlt = descAlt;
        Categoria = categoria;
        Continente = continente;
    }
}