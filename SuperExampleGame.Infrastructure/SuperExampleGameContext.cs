using Microsoft.EntityFrameworkCore;
using SuperExampleGame.Domain;
using SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate;
using SuperExampleGame.Domain.AggregatesModel.UsuariosAggregate;

namespace SuperExampleGame.Infrastructure
{
    public class SuperExampleGameContext:DbContext 
    {
        public SuperExampleGameContext(DbContextOptions<SuperExampleGameContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSets

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Guerrero> Guerreros { get; set; }

        #endregion
    }

}
