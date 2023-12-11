using Microsoft.AspNetCore.Mvc;

namespace Autoszerelo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AutoszereloController : ControllerBase
	{
		private static List<Munka> munkak = new();

		[HttpGet("GetAll")]
		public ActionResult<List<Munka>> Get()
		{
			return Ok(munkak);
		}

		[HttpGet]
		public ActionResult<Munka> GetSingle()
		{
			return Ok(munkak[0]);
		}
	}
}
