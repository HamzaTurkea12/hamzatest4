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
	public class TumorDurumuConfiguration : IEntityTypeConfiguration<TumorDurumu>
	{
		public void Configure(EntityTypeBuilder<TumorDurumu> builder)
		{
			builder.Property(x => x.TumorBolgesi).HasMaxLength(200);
		}
	}
}
