using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class MetasazDurumu : BaseEntity
	{
		public string MetastazOrganı { get; set; }
		public string LenfNoduIslemivarmı { get; set; }
		public string LenfNoduMetastazvarmı { get; set; }
		public string LenfNoduLokasyonu { get; set; }
		public string UzakMetastazvarmı { get; set; }
		public string UzakMetastazLokasyonu { get; set; }

		public List<FormMetastazDurumu> FormMetastazDurumus { get; set; }
	}
}
