using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class ViralEnfeksiyon : BaseEntity
	{
		public string Virus { get; set; }
		public string TestDurumu { get; set; }
		public string Sonuc { get; set; }
		public List<FormViralEnfeksiyon> FormViralEnfeksiyons { get; set; }
	}
}
