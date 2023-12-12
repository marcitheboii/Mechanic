using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Autoszerelo.Data
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{

		}
		public DbSet<Ugyfel> Ugyfelek { get; set; }
		public DbSet<Munka> Munkak { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=true;TrustServerCertificate=True;");
		}
	}
}