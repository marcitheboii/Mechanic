using Microsoft.AspNetCore.Mvc;

namespace Autoszerelo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AutoszereloController : ControllerBase
	{
		private readonly IMunkaService _munkaService;

		public AutoszereloController(IMunkaService munkaService)
        {
			_munkaService = munkaService;
		}

        [HttpGet("GetAll")]
		public ActionResult<List<Munka>> Get()
		{
			return Ok(_munkaService.GetAllMunka());
		}

		[HttpGet("{id}")]
		public ActionResult<Munka> GetSingle(int id)
		{
			return Ok(_munkaService.GetMunkaById(id));
		}

		[HttpPost]
		public ActionResult<List<Munka>> AddMunka(Munka ujmunka)
		{
			return Ok(_munkaService.AddMunka(ujmunka));
		}
	}
}
