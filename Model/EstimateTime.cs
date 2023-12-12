using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;

namespace Autoszerelo.Model
{
	public class EstimateTime
	{
		public double calculate(Kategoria kategoria, int gyartas, int hibaSulyossag)
		{
			int kat = 0;
			double kor = 0;
			double hiba = 0;

			switch (kategoria)
			{
				case Kategoria.karosszeria:
					kat = 3;
					break;
				case Kategoria.motor:
					kat = 8;
					break;
				case Kategoria.futomu:
					kat = 6;
					break;
				case Kategoria.fekberendezes:
					kat = 4;
					break;
				default:
					break;
			}

			int oldness = DateTime.Now.Year - gyartas;
			switch (oldness)
			{
				case <5:
					kor = 0.5;
					break;
				case < 10:
					kor = 1;
					break;
				case < 20:
					kor = 1.5;
					break;
				default:
					kor = 2;
					break;
			}

			switch (hibaSulyossag)
			{
				case <2:
					hiba = 0.2;
					break;
				case < 4:
					hiba = 0.4;
					break;
				case < 7:
					hiba = 0.6;
					break;
				case < 9:
					hiba = 0.8;
					break;
				case <= 10:
					hiba = 1;
					break;
				default:
					break;
			}

			return (kat * kor * hiba);
		}
	}
}
