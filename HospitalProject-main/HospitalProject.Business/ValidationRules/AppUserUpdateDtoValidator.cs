﻿using FluentValidation;
using HospitalProject.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Business.ValidationRules
{
	public class AppUserUpdateDtoValidator : AbstractValidator<AppUserUpdateDto>
	{
		public AppUserUpdateDtoValidator()
		{
			RuleFor(x => x.Id);
			RuleFor(x => x.FirstName).NotEmpty();
			RuleFor(x => x.Surname).NotEmpty();
			RuleFor(x => x.GenderId).NotEmpty();
			RuleFor(x => x.Password).NotEmpty();
			RuleFor(x => x.PhoneNumber).NotEmpty();
			RuleFor(x => x.UserName).NotEmpty();

		}
	}
}