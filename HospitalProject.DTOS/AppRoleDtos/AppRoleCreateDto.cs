﻿using HospitalProject.DTOS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DTOS
{
	public class AppRoleCreateDto : IDto
	{

		public string Definition { get; set; }
	}
}