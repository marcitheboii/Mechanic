using LinqToDB;

namespace Autoszerelo.Services.UgyfelService
{
	public class UgyfelService : IUgyfelService
	{
		private readonly MyDbContext _context;

		public UgyfelService(MyDbContext context)
		{
			_context = context;
		}

		public async Task<List<Ugyfel>> AddUgyfel(Ugyfel ugyfel)
		{
			_context.Ugyfelek.Add(ugyfel);
			await _context.SaveChangesAsync();
			return await _context.Ugyfelek.ToListAsync();
		}

		public async Task<List<Ugyfel>?> DeleteUgyfel(int id)
		{
			var ugyfel = await _context.Ugyfelek.FindAsync(id);
			if (ugyfel is null)
				return null;

			_context.Ugyfelek.Remove(ugyfel);
			await _context.SaveChangesAsync();

			return await _context.Ugyfelek.ToListAsync();
		}

		public async Task<List<Ugyfel>> GetAllUgyfel()
		{
			var ugyfelek = await _context.Ugyfelek.ToListAsync();
			return ugyfelek;
		}

		public async Task<Ugyfel> GetSingleUgyfel(int id)
		{
			var ugyfel = await _context.Ugyfelek.FindAsync(id);
			if (ugyfel is null)
				return null;

			return ugyfel;
		}

		public async Task<List<Ugyfel>?> UpdateUgyfel(int id, Ugyfel request)
		{
			var ugyfel = await _context.Ugyfelek.FindAsync(id);
			if (ugyfel is null)
				return null;

			ugyfel.Nev = request.Nev;
			ugyfel.Lakcim = request.Lakcim;
			ugyfel.Email = request.Email;

			await _context.SaveChangesAsync();

			return await _context.Ugyfelek.ToListAsync();
		}
	}
}
