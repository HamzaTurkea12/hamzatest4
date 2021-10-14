using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class AileMedikalGecmisi : BaseEntity
	{
		public string Yakinlik { get; set; }
		public string Tani { get; set; }
		public string TaniYili { get; set; }

		public List<FormAileMedikalGecmisi> FormAileMedikalGecmisis { get; set; }
	}
}
