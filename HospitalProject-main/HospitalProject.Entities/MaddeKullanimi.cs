using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class MaddeKullanimi : BaseEntity
	{
		public string Durum { get; set; }
		public string Tip { get; set; }
		public int GundeMiktar { get; set; }
		public int MevcutDurum { get; set; }

		public List<Form> Forms { get; set; }

	}
}
