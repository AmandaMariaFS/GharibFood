namespace GharibFood.Models;

public class Receita
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Imagem { get; set; }
    public string Text_alt { get; set; }
    public string Categoria { get; set; }
    public string Continente { get; set; }
    public string Video { get; set; }
    public string Preparo { get; set; }
    public string Curiosidade { get; set; }
    public string Tempo { get; set; }
    public string Rendimento { get; set; }
    public int Favoritos { get; set; }
    public int Estrelas { get; set; }
    public int Comentarios { get; set; }


    public Receita(int id, string nome, string imagem, string text_alt, string categoria, string continente, string video, string preparo, string curiosidade, string tempo, string rendimento, int favoritos, int estrelas, int comentarios)
    {
        Id = id;
        Nome = nome;
        Imagem = imagem;
        Text_alt = text_alt;
        Categoria = categoria;
        Continente = continente;
        Video = video;
        Preparo = preparo;
        Curiosidade = curiosidade;
        Tempo = tempo;
        Rendimento = rendimento;
        Favoritos = favoritos;
        Estrelas = estrelas;
        Comentarios = comentarios;
    }

    public Receita()
    {
        
    } 
}