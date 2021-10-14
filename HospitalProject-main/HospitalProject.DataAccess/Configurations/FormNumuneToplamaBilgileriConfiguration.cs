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
	public class FormNumuneToplamaBilgileriConfiguration : IEntityTypeConfiguration<FormNumuneToplamaBilgileri>
	{
		public void Configure(EntityTypeBuilder<FormNumuneToplamaBilgileri> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.NumuneToplamaBilgileriId

			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormNumuneToplamaBilgileris).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.NumuneToplamaBilgisi).WithMany(x => x.FormNumuneToplamaBilgileris).HasForeignKey(x => x.NumuneToplamaBilgileriId);

		}
	}
}
