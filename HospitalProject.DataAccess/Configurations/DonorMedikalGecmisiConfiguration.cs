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
	public class DonorMedikalGecmisiConfiguration : IEntityTypeConfiguration<DonorMedikalGecmisi>
	{
		public void Configure(EntityTypeBuilder<DonorMedikalGecmisi> builder)
		{
			builder.Property(x => x.HastalikTedaviBozukluk).IsRequired();
			builder.Property(x => x.TaniTarihi).HasDefaultValueSql("getdate()").IsRequired();
			builder.Property(x => x.Durumu).IsRequired();
			builder.Property(x => x.ICD10Kodu).IsRequired();
		}
	}
}
