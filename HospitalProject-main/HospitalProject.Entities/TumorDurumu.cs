using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class TumorDurumu : BaseEntity
	{
		public string TumorBolgesi { get; set; }
		public decimal TumorBoyutu { get; set; }
		public string TNM { get; set; }
		public string Evre { get; set; }
		public string TumorTipi { get; set; }
		public List<Form> Forms { get; set; }
	}
}
