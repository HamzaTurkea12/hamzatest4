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
	public class TaniBilgileriConfiguration : IEntityTypeConfiguration<TaniBilgileri>
	{
		public void Configure(EntityTypeBuilder<TaniBilgileri> builder)
		{
			builder.Property(x => x.TaniTarihi).HasDefaultValueSql("getdate()").IsRequired();
			builder.Property(x => x.KlinikTani).IsRequired();
			builder.Property(x => x.ICD10TanıKodu).IsRequired();
		}
	}
}
