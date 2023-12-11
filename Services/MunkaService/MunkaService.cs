using Autoszerelo.Model;
using Azure.Core;
using LinqToDB;

namespace Autoszerelo.Services.MunkaService
{
	public class MunkaService : IMunkaService
	{
		private readonly MyDbContext _context;

		public MunkaService(MyDbContext context)
		{
			_context = context;
		}

		public async Task<List<Munka>> AddMunka(Munka munka)
		{
			_context.Munkak.Add(munka);
			await _context.SaveChangesAsync();
			return await _context.Munkak.ToListAsync();
		}

		public async Task<List<Munka>?> DeleteMunka(int id)
		{
			var munka = await _context.Munkak.FindAsync(id);
			if (munka is null)
				return null;

			_context.Munkak.Remove(munka);
			await _context.SaveChangesAsync();

			return await _context.Munkak.ToListAsync();
		}

		public async Task<List<Munka>> GetAllMunka()
		{
			var munkak = await _context.Munkak.ToListAsync();
			return munkak;
		}

		public async Task<Munka?> GetSingleMunka(int id)
		{
			var munka = await _context.Munkak.FindAsync(id);
			if (munka is null)
				return null;

			return munka;
		}

		public async Task<List<Munka>?> UpdateMunka(int id, Munka request)
		{
			var munka = await _context.Munkak.FindAsync(id);
			if (munka is null)
				return null;

			munka.UgyfelId = request.UgyfelId;
			munka.Rendszam = request.Rendszam;
			munka.GyartasiEv = request.GyartasiEv;
			munka.Kategoria = request.Kategoria;
			munka.HibaLeiras = request.HibaLeiras;
			munka.HibaSulyossag = request.HibaSulyossag;
			munka.Allapot = request.Allapot;

			await _context.SaveChangesAsync();

			return await _context.Munkak.ToListAsync();
		}
	}
}
