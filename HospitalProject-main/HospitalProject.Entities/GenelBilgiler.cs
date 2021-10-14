using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class GenelBilgiler : BaseEntity
	{
		public string Ulke { get; set; }
		public string EtnikKoken { get; set; }
		public DateTime DogumTarihi { get; set; }
		public string EgitimSeviyesi { get; set; }
		public decimal Boy { get; set; }
		public decimal Kilo { get; set; }
		
	


		public List<Form> Forms { get; set; }

	}
}
