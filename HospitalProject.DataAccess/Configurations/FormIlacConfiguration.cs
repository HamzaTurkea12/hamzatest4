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
	public class FormIlacConfiguration : IEntityTypeConfiguration<FormIlac>
	{
		public void Configure(EntityTypeBuilder<FormIlac> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.IlacId
			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormIlacs).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.Ilac).WithMany(x => x.FormIlacs).HasForeignKey(x => x.IlacId);
		}
	}
}
