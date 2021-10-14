using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormIlac :BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }

		public int IlacId { get; set; }
		public Ilac Ilac { get; set; }
	}
}
