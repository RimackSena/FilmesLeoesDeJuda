using FIlmesLeoesDeJuda.DAL.Entities;
using FIlmesLeoesDeJuda.DAL.Mappings;
using Microsoft.EntityFrameworkCore;


namespace FIlmesLeoesDeJuda.DAL
{
    public class FilmesLeoesDeJudaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public FilmesLeoesDeJudaContext(DbContextOptions<FilmesLeoesDeJudaContext> options) : base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
