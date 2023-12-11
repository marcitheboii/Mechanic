using Microsoft.AspNetCore.Mvc;

namespace Autoszerelo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AutoszereloController : ControllerBase
	{
		private static List<Munka> munkak = new List<Munka> {
			new Munka(),
			new Munka{ Id=1, Kategoria = Kategoria.fekberendezes}
		};

		[HttpGet("GetAll")]
		public ActionResult<List<Munka>> Get()
		{
			return Ok(munkak);
		}

		[HttpGet("{id}")]
		public ActionResult<Munka> GetSingle(int id)
		{
			return Ok(munkak.FirstOrDefault(c => c.Id == id));
		}

		[HttpPost]
		public ActionResult<List<Munka>> AddMunka(Munka ujmunka)
		{
			munkak.Add(ujmunka);

			return Ok(munkak);
		}
	}
}
