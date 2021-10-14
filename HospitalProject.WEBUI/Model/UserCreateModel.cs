using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalProject.WEBUI.Model
{
	public class UserCreateModel
	{
		public string FirstName { get; set; }
		public string Surname { get; set; }

		public string UserName { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }//eklediklerimiz var DTO dışında bu gibi

		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public int GenderId { get; set; }
		public SelectList Genders { get; set; }
	}
}
