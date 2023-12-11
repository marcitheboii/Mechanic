using System.ComponentModel.DataAnnotations;

namespace Autoszerelo.Model
{
	public class Ugyfel
	{
        [Required]
        public int Id { get; set; }

		[Required]
		public string Nev { get; set; }

		[Required]
		public string Lakcim { get; set; }

		[Required]
		[EmailAddress]
        public string Email { get; set; }
    }
}
