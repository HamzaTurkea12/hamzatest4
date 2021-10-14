using HospitalProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Configurations
{
	public class FormImmunhistokimyaConfiguration : IEntityTypeConfiguration<FormImmunhistokimya>
	{
		public void Configure(EntityTypeBuilder<FormImmunhistokimya> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.ImmunhistokimyaId
			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormImmunhistokimyas).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.ImmunhistokimyaTest).WithMany(x => x.FormImmunhistokimyas).HasForeignKey(x => x.ImmunhistokimyaId);

			
		}
	}
}
