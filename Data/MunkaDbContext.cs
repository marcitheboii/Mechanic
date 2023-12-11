using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Autoszerelo.Data
{
	public class MunkaDbContext : DbContext
	{
        public MunkaDbContext(DbContextOptions<MunkaDbContext> options) : base(options)
        {
            
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=true;TrustServerCertificate=True;");
		}

		public DbSet<Munka> Munkak { get; set; }
    }
}
