using Autoszerelo.Model;

namespace Autoszerelo.Services.MunkaService
{
	public class MunkaService : IMunkaService
	{
		private static List<Munka> munkak = new List<Munka> {
			new Munka(),
			new Munka{ Id=1, Kategoria = Kategoria.fekberendezes}
		};

		public List<Munka> AddMunka(Munka ujmunka)
		{
			munkak.Add(ujmunka);

			return munkak;
		}

		public List<Munka> GetAllMunka()
		{
			return munkak;
		}

		public Munka GetMunkaById(int id)
		{
			return munkak.FirstOrDefault(c => c.Id == id);
		}
	}
}
