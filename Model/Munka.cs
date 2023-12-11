using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace Autoszerelo.Model
{
	public class Munka
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public int UgyfelId { get; set; } = 0;

		[Required]
		public string Rendszam { get; set; } = "XXX-YYY";

		[Required]
		[Range(typeof(DateTime), "1990-01-01", "9999-01-01")]
		public DateTime GyartasiEv { get; set; }

		[Required]
		public Kategoria Kategoria { get; set; }

		[Required]
		public string HibaLeiras { get; set; } = string.Empty;

		[Required]
		[Range(1, 10)]
		public int HibaSulyossag { get; set; } = 1;

		[Required]
		public Allapot Allapot { get; set; } = Allapot.felvett_munka;

		[HiddenInput]
		public Ugyfel Ugyfel { get; set; }

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
