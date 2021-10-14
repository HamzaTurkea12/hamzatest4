﻿using HospitalProject.DTOS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DTOS
{
	public class AppRoleUpdateDto : IUpdateDto
	{
		public int Id { get; set; }
		public string Definition { get; set; }
	}
}
