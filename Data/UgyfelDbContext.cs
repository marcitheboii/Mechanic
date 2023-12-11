using Autoszerelo.Model;
using Microsoft.EntityFrameworkCore;

namespace Autoszerelo.Data
{
	public class UgyfelDbContext : DbContext
	{
		public UgyfelDbContext(DbContextOptions<UgyfelDbContext> options)
			: base(options)
		{
		}

		public DbSet<Ugyfel> Ugyfelek { get; set; }
	}
}
