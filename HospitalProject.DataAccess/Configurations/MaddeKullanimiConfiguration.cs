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
	public class MaddeKullanimiConfiguration : IEntityTypeConfiguration<MaddeKullanimi>
	{
		public void Configure(EntityTypeBuilder<MaddeKullanimi> builder)
		{
			builder.Property(x => x.GundeMiktar).IsRequired();
			builder.Property(x => x.Tip).IsRequired();
			builder.Property(x => x.Durum).IsRequired();
			builder.Property(x => x.MevcutDurum).IsRequired();
			
		}
	}
}
