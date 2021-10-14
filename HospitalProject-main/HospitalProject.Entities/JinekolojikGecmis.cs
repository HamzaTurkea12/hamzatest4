using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class JinekolojikGecmis : BaseEntity
	{
		public string MenstüralDurum { get; set; }
		public DateTime SonReglTarihi { get; set; }
		public string Hamilelikler { get; set; }
		public string Dogumlar { get; set; }


		public List<Form> Forms { get; set; }
	}
}
