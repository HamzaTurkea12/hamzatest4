using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormKanserTedavisi : BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }

		public int KanserTedavisiId { get; set; }
		public KanserTedavisi KanserTedavisi { get; set; }
	}
}
