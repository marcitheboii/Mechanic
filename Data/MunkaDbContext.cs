using Autoszerelo.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Autoszerelo.Data
{
	public class MunkaDbContext : DbContext
	{
        public MunkaDbContext(DbContextOptions<MunkaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Munka> Munkak { get; set; }
    }
}
