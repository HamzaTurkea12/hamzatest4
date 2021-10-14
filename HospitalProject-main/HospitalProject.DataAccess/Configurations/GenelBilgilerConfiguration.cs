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
	public class GenelBilgilerConfiguration : IEntityTypeConfiguration<GenelBilgiler>
	{
		public void Configure(EntityTypeBuilder<GenelBilgiler> builder)
		{
			builder.Property(x => x.Boy).IsRequired();
			builder.Property(x => x.DogumTarihi).HasDefaultValueSql("getdate()").IsRequired();
			builder.Property(x => x.EgitimSeviyesi).IsRequired();
			builder.Property(x => x.EtnikKoken).IsRequired();
			builder.Property(x => x.Ulke).IsRequired();
			builder.Property(x => x.Kilo).IsRequired();
		}
	}
}
