
using Microsoft.EntityFrameworkCore;
using PustokProject.CoreModels;

namespace PustokProject.Persistance
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Slider> Sliders {  get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer(@"Server=DESKTOP-MV8SC5T\SQLEXPRESS;Database=PracticeNov30Pustok;TrustServerCertificate=True;Encrypt=False;Trusted_Connection=True");
        }
    }
}
