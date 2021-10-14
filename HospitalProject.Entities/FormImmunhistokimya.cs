using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormImmunhistokimya : BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }
		public int ImmunhistokimyaId { get; set; }
		public ImmunhistokimyaTest ImmunhistokimyaTest { get; set; }
	}
}
