using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace Autoszerelo.Model
{
	public class Munka
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[RegularExpression(@"^(?![\s!?_\-:;#])^[A-Z]{3}-\d{3}$")]

		public string Rendszam { get; set; } = "XXX-111";

		[Required]
		[Range(1900, 2023)]
		public int GyartasiEv { get; set; }

		[Required]
		public Kategoria Kategoria { get; set; }

		[Required]
		public string HibaLeiras { get; set; } = string.Empty;

		[Required]
		[Range(1, 10)]
		public int HibaSulyossag { get; set; } = 1;

		[Required]
		public Allapot Allapot { get; set; } = Allapot.felvett_munka;

		[Required]
		public int UgyfelId { get; set; } = 0;

		public Ugyfel Ugyfel { get; set; }

		public double? EstimatedValue
		{
			get
			{
				var temp = new EstimateTime();
				return temp.calculate(this.Kategoria,this.GyartasiEv,this.HibaSulyossag);
			}
		}

	}

	[JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Kategoria
    {
		karosszeria,
        motor,
        futomu,
        fekberendezes
	}

	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum Allapot
    {
        felvett_munka,
        elvegzes_alatt,
        befejezett
    }
}
