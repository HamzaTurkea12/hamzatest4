using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormNumuneToplamaBilgileri : BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }

		public int NumuneToplamaBilgileriId { get; set; }
		public NumuneToplamaBilgisi NumuneToplamaBilgisi { get; set; }
	}
}
