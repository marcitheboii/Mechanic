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

		[HttpPut("{id}")]
		public ActionResult<List<Munka>> UpdateMunka(int id,Munka request)
		{
			var munka = _munkaService.GetMunkaById(id);

			if(munka == null)
			{
				return NotFound("Nincs ilyen munka");
			}

			munka.UgyfelId = request.UgyfelId;
			munka.Rendszam = request.Rendszam;
			munka.GyartasiEv = request.GyartasiEv;
			munka.Kategoria = request.Kategoria;
			munka.HibaLeiras = request.HibaLeiras;
			munka.HibaSulyossag = request.HibaSulyossag;
			munka.Allapot = request.Allapot;

			return Ok(munka);
		}

		[HttpDelete("{id}")]
		public ActionResult<List<Munka>> RemoveMunka(int id,Munka munka)
		{
			var regimunka = _munkaService.GetMunkaById(id);

			if(regimunka == null)
			{
				return NotFound("Nincs ilyen munka");
			}

			return Ok(_munkaService.RemoveMunka(regimunka));
		}
	}
}
