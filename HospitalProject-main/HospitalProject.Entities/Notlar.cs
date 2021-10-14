using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class Notlar: BaseEntity
	{
		public string Description { get; set; }
		public List<Form> Forms { get; set; }
	}
}
