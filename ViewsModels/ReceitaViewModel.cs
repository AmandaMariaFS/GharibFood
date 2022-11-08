namespace GharibFood.ViewModels;

public class ReceitaViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CaminhoFoto { get; set; }
    public string DescAlt { get; set; }
    public string Categoria { get; set; }
    public string Continente { get; set; }
    public string Video { get; set; }
    public string Preparo { get; set; }
    public string Rendimento { get; set; }
    public int Favoritos { get; set; }
    public int Comentarios { get; set; }


    public ReceitaViewModel(int id, string nome, string caminhoFoto, string descAlt, string categoria, string continente, string video, string preparo, string rendimento, int favoritos, int comentarios)
    {
        Id = id;
        Nome = nome;
        CaminhoFoto = caminhoFoto;
        DescAlt = descAlt;
        Categoria = categoria;
        Continente = continente;
        Video = video;
        Preparo = preparo;
        Rendimento = rendimento;
        Favoritos = favoritos;
        Comentarios = comentarios;
    }

    public ReceitaViewModel()
    {
        
    }
}