using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class FormDonorMedikalGecmisi : BaseEntity
	{
		public int FormId { get; set; }
		public Form Form { get; set; }

		public int DonorMedikalGecmisiId { get; set; }
		public DonorMedikalGecmisi DonorMedikalGecmisi { get; set; }
	}
}
