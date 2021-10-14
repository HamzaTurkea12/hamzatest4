using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class TaniBilgileri : BaseEntity
	{
		public DateTime TaniTarihi { get; set; }
		public string KlinikTani { get; set; }
		public string ICD10TanıKodu { get; set; }

		public List<FormTanıBilgileri> FormTanıBilgileris { get; set; }
	}
}
