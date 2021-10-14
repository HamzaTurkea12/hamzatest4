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
	public class FormViralEnfeksiyonConfiguration : IEntityTypeConfiguration<FormViralEnfeksiyon>
	{
		public void Configure(EntityTypeBuilder<FormViralEnfeksiyon> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.ViralEnfeksiyonId
			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormViralEnfeksiyons).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.ViralEnfeksiyon).WithMany(x => x.FormViralEnfeksiyons).HasForeignKey(x => x.ViralEnfeksiyonId);
		}
	}
}
