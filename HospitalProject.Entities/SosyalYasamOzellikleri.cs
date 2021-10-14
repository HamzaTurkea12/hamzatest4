using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class SosyalYasamOzellikleri : BaseEntity
	{

		public string Meslek { get; set; }
		public string CevreselMazuriyet { get; set; }


		public List<Form> Forms { get; set; }
	}
}
