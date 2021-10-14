using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormViralEnfeksiyon : BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }

		public int ViralEnfeksiyonId { get; set; }
		public ViralEnfeksiyon ViralEnfeksiyon { get; set; }
	}
}
