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
	public class ImmunhistokimyaConfigurations : IEntityTypeConfiguration<ImmunhistokimyaTest>
	{
		public void Configure(EntityTypeBuilder<ImmunhistokimyaTest> builder)
		{
			builder.Property(x => x.Virus).HasMaxLength(200);
			builder.HasData(new ImmunhistokimyaTest[] {

				new()
				{
					Id=2,
					Virus="ER"
				},
				new()
				{
					Id=3,
					Virus="PR"
				},
				new()
				{
					Id=4,
					Virus="HER2/NEU"
				},
				new()
				{
					Id=5,
					Virus="MLH1"
				},
				new()
				{
					Id=6,
					Virus="PMS2"
				},
				new()
				{
					Id=7,
					Virus="MSH2"
				},
				new()
				{
					Id=8,
					Virus="MSH6"
				},




			});
		}
	}
}
