using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class PatolojiDurumu : BaseEntity
	{
		public string NumuneToplamaSekli { get; set; }
		public string MikroskopikAnaliz { get; set; }
		public string PatolojikTanı { get; set; }
		public List<Form> Forms { get; set; }
	}
}
