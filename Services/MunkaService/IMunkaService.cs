namespace Autoszerelo.Services.MunkaService
{
	public interface IMunkaService
	{
		List<Munka> GetAllMunka();

		Munka GetMunkaById(int id);

		List<Munka> AddMunka(Munka ujmunka);

		List<Munka> RemoveMunka(Munka regimunka);
	}
}
