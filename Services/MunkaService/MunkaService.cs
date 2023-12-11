using Autoszerelo.Model;
using Azure.Core;

namespace Autoszerelo.Services.MunkaService
{
	public class MunkaService : IMunkaService
	{
		private static List<Munka> munkak = new List<Munka> {
			new Munka{ Id=1, Kategoria = Kategoria.fekberendezes, Rendszam="NUY-959"},
			new Munka{ Id=2, Kategoria = Kategoria.motor,Rendszam="MCU-859"}
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
