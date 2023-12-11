namespace Autoszerelo.Services.UgyfelService
{
	public interface IUgyfelService
	{
		Task<List<Ugyfel>> GetAllUgyfel();

		Task<Ugyfel> GetSingleUgyfel(int id);

		Task<List<Ugyfel>> AddUgyfel(Ugyfel ugyfel);

		Task<List<Ugyfel>?> UpdateUgyfel(int id, Ugyfel request);

		Task<List<Ugyfel>?> DeleteUgyfel(int id);
	}
}
