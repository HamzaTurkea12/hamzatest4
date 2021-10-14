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
	public class NumuneToplamaBilgileriConfiguration : IEntityTypeConfiguration<NumuneToplamaBilgisi>
	{
		public void Configure(EntityTypeBuilder<NumuneToplamaBilgisi> builder)
		{
			builder.Property(x => x.ToplamaTarihi).HasDefaultValueSql("getdate()").IsRequired();
			builder.Property(x => x.ToplamaSaati).IsRequired();
			builder.Property(x => x.AnotomikBolge).IsRequired();
			builder.Property(x => x.ToplamaSekli).IsRequired();

		}
	}
}
