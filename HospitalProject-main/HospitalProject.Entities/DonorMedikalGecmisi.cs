using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class DonorMedikalGecmisi : BaseEntity
	{
		public string HastalikTedaviBozukluk { get; set; }
		public DateTime TaniTarihi { get; set; }
		public string Durumu { get; set; }
		public int ICD10Kodu { get; set; }

		public List<FormDonorMedikalGecmisi> FormDonorMedikalGecmisis { get; set; }
	}
}
