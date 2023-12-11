namespace Autoszerelo.Services.MunkaService
{
	public interface IMunkaService
	{
		Task<List<Munka>> GetAllMunka();

		Task<Munka> GetSingleMunka(int id);

		Task<List<Munka>> AddMunka(Munka munka);

		Task<List<Munka>?> UpdateMunka(int id, Munka request);
		Task<List<Munka>?> DeleteMunka(int id);
	}
}
