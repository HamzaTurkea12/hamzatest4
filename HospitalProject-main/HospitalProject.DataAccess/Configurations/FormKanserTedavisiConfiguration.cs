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
	public class FormKanserTedavisiConfiguration : IEntityTypeConfiguration<FormKanserTedavisi>
	{
		public void Configure(EntityTypeBuilder<FormKanserTedavisi> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.KanserTedavisiId

			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormKanserTedavisis).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.KanserTedavisi).WithMany(x => x.FormKanserTedavisis).HasForeignKey(x => x.KanserTedavisiId);

		}
	}
}
