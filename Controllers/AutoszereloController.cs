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
		public async Task<ActionResult<List<Munka>>> GetAllMunka()
		{
			return await _munkaservice.GetAllMunka();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Munka>> GetSingleMunka(int id)
		{
			var result = await _munkaservice.GetSingleMunka(id);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}

		[HttpPost]
		public async Task<ActionResult<List<Munka>>> AddMunka(Munka munka)
		{
			var result = await _munkaservice.AddMunka(munka);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<List<Munka>>> UpdateMunka(int id, Munka request)
		{
			var result = await _munkaservice.UpdateMunka(id, request);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<List<Munka>>> DeleteMunka(int id)
		{
			var result = await _munkaservice.DeleteMunka(id);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}
	}
}
