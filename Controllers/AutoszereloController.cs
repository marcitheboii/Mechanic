using Microsoft.AspNetCore.Mvc;

namespace Autoszerelo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MunkaController : ControllerBase
	{
		private readonly IMunkaService _munkaservice;

		public MunkaController(IMunkaService munkaService)
		{
			_munkaservice = munkaService;
		}

		[HttpGet]
		public async Task<ActionResult<List<Munka>>> GetAllHeroes()
		{
			return await _munkaservice.GetAllMunka();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Munka>> GetSingleHero(int id)
		{
			var result = await _munkaservice.GetSingleMunka(id);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}

		[HttpPost]
		public async Task<ActionResult<List<Munka>>> AddHero(Munka hero)
		{
			var result = await _munkaservice.AddMunka(hero);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<List<Munka>>> UpdateHero(int id, Munka request)
		{
			var result = await _munkaservice.UpdateMunka(id, request);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<List<Munka>>> DeleteHero(int id)
		{
			var result = await _munkaservice.DeleteMunka(id);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}
	}
}
