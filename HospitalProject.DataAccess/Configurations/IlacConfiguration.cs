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
	public class IlacConfiguration : IEntityTypeConfiguration<Ilac>
	{
		public void Configure(EntityTypeBuilder<Ilac> builder)
		{
			builder.Property(x => x.IlacAdı).IsRequired();
			builder.Property(x => x.Doz).IsRequired();
			builder.Property(x => x.Birim).IsRequired();
			builder.Property(x => x.KullanımSekli).IsRequired();
			builder.Property(x => x.Siklik).IsRequired();
			builder.Property(x => x.MevcutDurum).IsRequired();
		}
	}
}
