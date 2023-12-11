using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Autoszerelo.Data
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
		{

		}

		public DbSet<Munka> Munkak { get; set; }
		public DbSet<Ugyfel> Ugyfelek { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=true;TrustServerCertificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);


			modelBuilder.Entity<Munka>()
				.HasOne(b => b.Ugyfel)
				.WithMany(a => a.Munkak)
				.HasForeignKey(b => b.UgyfelId);
		}
	}
}
