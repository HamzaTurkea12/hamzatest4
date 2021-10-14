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
	public class FormDonorMedikalGecmisiConfiguration : IEntityTypeConfiguration<FormDonorMedikalGecmisi>
	{
		public void Configure(EntityTypeBuilder<FormDonorMedikalGecmisi> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.DonorMedikalGecmisiId

			}).IsUnique();
			builder.HasOne(x => x.Form).WithMany(x => x.FormDonorMedikalGecmisis).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.DonorMedikalGecmisi).WithMany(x => x.FormDonorMedikalGecmisis).HasForeignKey(x => x.DonorMedikalGecmisiId);
		}
	}
}
