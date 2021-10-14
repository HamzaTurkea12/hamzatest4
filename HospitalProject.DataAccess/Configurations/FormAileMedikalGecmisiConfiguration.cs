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
	public class FormAileMedikalGecmisiConfiguration : IEntityTypeConfiguration<FormAileMedikalGecmisi>
	{
		public void Configure(EntityTypeBuilder<FormAileMedikalGecmisi> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.AileMedikalGecmisiId

			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormAileMedikalGecmisis).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.AileMedikalGecmisi).WithMany(x => x.FormAileMedikalGecmisis).HasForeignKey(x => x.AileMedikalGecmisiId);

		}
	}
}
