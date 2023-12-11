using Microsoft.AspNetCore.Mvc;

namespace Autoszerelo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MunkaController : ControllerBase
	{
		private readonly IMunkaService _munkaservice;

		private readonly IUgyfelService _ugyfelservice;

		public MunkaController(IMunkaService munkaService, IUgyfelService ugyfelservice)
		{
			_munkaservice = munkaService;
			_ugyfelservice = ugyfelservice;
		}

		[HttpGet("getAllMunka")]
		public async Task<ActionResult<List<Munka>>> GetAllMunka()
		{
			return await _munkaservice.GetAllMunka();
		}

		[HttpGet("getSingleMunka/{id}")]
		public async Task<ActionResult<Munka>> GetSingleMunka(int id)
		{
			var result = await _munkaservice.GetSingleMunka(id);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}

		[HttpPost("addMunka")]
		public async Task<ActionResult<List<Munka>>> AddMunka(Munka munka)
		{
			var result = await _munkaservice.AddMunka(munka);
			return Ok(result);
		}

		[HttpPut("updateMunka/{id}")]
		public async Task<ActionResult<List<Munka>>> UpdateMunka(int id, Munka request)
		{
			var result = await _munkaservice.UpdateMunka(id, request);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}

		[HttpDelete("deleteMunka/{id}")]
		public async Task<ActionResult<List<Munka>>> DeleteMunka(int id)
		{
			var result = await _munkaservice.DeleteMunka(id);
			if (result is null)
				return NotFound("Munka not found.");

			return Ok(result);
		}

		[HttpGet("getAllUgyfel")]
		public async Task<ActionResult<List<Ugyfel>>> GetAllUgyfel()
		{
			return await _ugyfelservice.GetAllUgyfel();
		}

		[HttpGet("getSingleUgyfel/{id}")]
		public async Task<ActionResult<Ugyfel>> GetSingleUgyfel(int id)
		{
			var result = await _ugyfelservice.GetSingleUgyfel(id);
			if (result is null)
				return NotFound("Ugyfel not found.");

			return Ok(result);
		}

		[HttpPost("addUgyfel")]
		public async Task<ActionResult<List<Ugyfel>>> AddUgyfel(Ugyfel ugyfel)
		{
			var result = await _ugyfelservice.AddUgyfel(ugyfel);
			return Ok(result);
		}

		[HttpPut("updateUgyfel/{id}")]
		public async Task<ActionResult<List<Ugyfel>>> UpdateUgyfel(int id, Ugyfel request)
		{
			var result = await _ugyfelservice.UpdateUgyfel(id, request);
			if (result is null)
				return NotFound("Ugyfel not found.");

			return Ok(result);
		}

		[HttpDelete("deleteUgyfel/{id}")]
		public async Task<ActionResult<List<Ugyfel>>> DeleteUgyfel(int id)
		{
			var result = await _ugyfelservice.DeleteUgyfel(id);
			if (result is null)
				return NotFound("Ugyfel not found.");

			return Ok(result);
		}
	}
}
