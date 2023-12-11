using Microsoft.AspNetCore.Mvc;

namespace Autoszerelo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AutoszereloController : ControllerBase
	{
		private static readonly Munka munka = new();

		[HttpGet]
		public ActionResult<Munka> Get()
		{
			return Ok(munka);
		}
	}
}
