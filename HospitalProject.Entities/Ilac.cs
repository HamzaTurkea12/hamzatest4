using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class Ilac : BaseEntity
	{
		public string IlacAdı { get; set; }
		public int Doz { get; set; }
		public string Birim { get; set; }
		public string KullanımSekli { get; set; }
		public string Siklik { get; set; }
		public string MevcutDurum { get; set; }


		public List<FormIlac> FormIlacs { get; set; }
	}
}
