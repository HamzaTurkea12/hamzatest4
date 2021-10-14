using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class NumuneToplamaBilgisi : BaseEntity
	{
		public DateTime ToplamaTarihi { get; set; }
		public string ToplamaSaati { get; set; }
		public string AnotomikBolge { get; set; }
		public string ToplamaSekli { get; set; }
		public List<FormNumuneToplamaBilgileri> FormNumuneToplamaBilgileris { get; set; }
	}
}
