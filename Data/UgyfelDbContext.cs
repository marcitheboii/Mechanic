using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;


namespace Autoszerelo.Data
{
	public class UgyfelDbContext : DbContext
	{
		public UgyfelDbContext(DbContextOptions<UgyfelDbContext> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=true;TrustServerCertificate=True;");
		}

		public DbSet<Ugyfel> Ugyfelek { get; set; }
	}
}
