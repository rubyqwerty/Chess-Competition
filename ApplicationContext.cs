using Microsoft.EntityFrameworkCore;


namespace Сhess_Сompetitions
{
    class ApplicationContext : DbContext
    {
        public DbSet<ChessPlayer> ChessPlayers { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=players;Trusted_Connection=True;");
        }
    }
}
