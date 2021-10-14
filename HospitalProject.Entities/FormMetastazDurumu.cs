using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormMetastazDurumu : BaseEntity
	{

		public int FormId { get; set; }
		public Form Form { get; set; }
		public int MetastazDurumuId { get; set; }
		public MetasazDurumu MetasazDurumu { get; set; }
	}
}
