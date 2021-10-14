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
	public class PatolojiDurumuConfiguration : IEntityTypeConfiguration<PatolojiDurumu>
	{
		public void Configure(EntityTypeBuilder<PatolojiDurumu> builder)
		{
			builder.Property(x => x.NumuneToplamaSekli).IsRequired();
			builder.Property(x => x.MikroskopikAnaliz).IsRequired();
			builder.Property(x => x.PatolojikTanı).IsRequired();
		}
	}
}
