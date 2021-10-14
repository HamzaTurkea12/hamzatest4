using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class ImmunhistokimyaTest : BaseEntity
	{
		public string Virus { get; set; }
		public string TestDurumu { get; set; }
		public string Sonuc { get; set; }
		public List<FormImmunhistokimya> FormImmunhistokimyas { get; set; }
	}
}
