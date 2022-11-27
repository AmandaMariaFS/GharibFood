using Microsoft.EntityFrameworkCore;

namespace GharibFood.Models;

public class GharibFoodContext : DbContext
{
    public DbSet<Receita> Receitas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Ingrediente> Ingredientes { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Favorito> Favoritos { get; set; }
    
    public GharibFoodContext(DbContextOptions<GharibFoodContext> options) : base(options)
    {
        
    }
}