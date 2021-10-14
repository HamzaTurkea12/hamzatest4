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
	public class FormMetastazDurumuConfiguration : IEntityTypeConfiguration<FormMetastazDurumu>
	{
		public void Configure(EntityTypeBuilder<FormMetastazDurumu> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.MetastazDurumuId

			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormMetastazDurumus).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.MetasazDurumu).WithMany(x => x.FormMetastazDurumus).HasForeignKey(x => x.MetastazDurumuId);
		}
	}
}
