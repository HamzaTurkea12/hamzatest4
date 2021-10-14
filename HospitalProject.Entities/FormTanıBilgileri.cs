using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormTanıBilgileri : BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }

		public int TaniBilgileriId { get; set; }
		public TaniBilgileri TaniBilgileri { get; set; }
	}
}
