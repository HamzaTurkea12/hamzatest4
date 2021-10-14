using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class KanserTedavisi : BaseEntity
	{
		public string TedaviTipi { get; set; }
		public DateTime TedaviBaslangicBitis { get; set; }
		public string TedaviSonucu { get; set; }
		public string TedaviUygulamaSekli { get; set; }

		public List<FormKanserTedavisi> FormKanserTedavisis { get; set; }
	}
}
