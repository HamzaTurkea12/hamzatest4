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
	public class ViralEnfeksiyonlarConfiguration : IEntityTypeConfiguration<ViralEnfeksiyon>
	{
		public void Configure(EntityTypeBuilder<ViralEnfeksiyon> builder)
		{
			builder.Property(x => x.Virus).IsRequired();
			builder.Property(x => x.TestDurumu).HasMaxLength(400);
			builder.Property(x => x.Sonuc).HasMaxLength(400);

			builder.HasData(new ViralEnfeksiyon[]
			{

				new()
				{
					Id=2,
					Virus ="HIV1/2"
				},

				new()
				{
					Id=3,
					Virus ="Hepatit A"
				},
				new()
				{
					Id=4,
					Virus ="Hepatit B"
				},
				new()
				{
					Id=5,
					Virus ="Hepatit C"
				},

				new()
				{
					Id=6,
					Virus ="Sifliz"
				},



			});


		}
	}
}
