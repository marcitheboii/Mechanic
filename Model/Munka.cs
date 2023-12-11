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
		public int UgyfelId { get; set; }

		[Required]
		public string Rendszam { get; set; }

		[Required]
		[Range(typeof(DateTime), "1990-01-01", "9999-01-01")]
		public DateTime GyartasiEv { get; set; }

		[Required]
		public Kategoria Kategoria { get; set; }

		[Required]
		public string HibaLeiras { get; set; }

		[Required]
		[Range(1,10)]
		public int HibaSulyossag { get; set; }

		[Required]
		public Allapot Allapot { get; set; }

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
