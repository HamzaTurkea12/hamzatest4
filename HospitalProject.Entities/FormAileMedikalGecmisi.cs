using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormAileMedikalGecmisi : BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }

		public int AileMedikalGecmisiId { get; set; }
		public AileMedikalGecmisi AileMedikalGecmisi { get; set; }
	}
}
