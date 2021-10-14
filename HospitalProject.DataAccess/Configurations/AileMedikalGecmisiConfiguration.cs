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
	public class AileMedikalGecmisiConfiguration : IEntityTypeConfiguration<AileMedikalGecmisi>
	{
		public void Configure(EntityTypeBuilder<AileMedikalGecmisi> builder)
		{
			builder.Property(x => x.Yakinlik).IsRequired();
			builder.Property(x => x.Tani).IsRequired();
			builder.Property(x => x.TaniYili).HasDefaultValueSql("getdate()").IsRequired();
		}
	}
}
