using Microsoft.EntityFrameworkCore;
using Jardin.Models;

namespace Jardin
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=PETU-STI-52\\\\SQLEXPRESS;Initial Catalog=ExempleTournoi;Integrated Security=True; TrustServerCertificate=Yes");
        }

        public DbSet<Jardins> jardins { get; set; }
        public DbSet<Legume> legumes { get; set; }
        public DbSet<Fruit> fruits { get; set; }
        public DbSet<Aliment> aliments { get; set; }
    }
}
