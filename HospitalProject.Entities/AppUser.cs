using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class AppUser: BaseEntity
	{
		//public int Id { get; set; }
		public string FirstName { get; set; }
		public string Surname { get; set; }

		public string UserName { get; set; }
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public int? GenderId { get; set; }
		public Gender Gender { get; set; }
		////public string Country { get; set; }
		////public string ComingFrom { get; set; }
		////public DateTime DateofBirth { get; set; }
		////public string EducationLevel { get; set; }
		////public decimal Height { get; set; }
		////public decimal Kilo { get; set; }
		////public string Profession { get; set; }

		public int FormId { get; set; }
		public Form Form { get; set; }


		public List<AppUserRole> AppUserRoles { get; set; }





	}
}
