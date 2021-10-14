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
	public class MetastazDurumuConfiguration : IEntityTypeConfiguration<MetasazDurumu>
	{
		public void Configure(EntityTypeBuilder<MetasazDurumu> builder)
		{
			builder.Property(x => x.MetastazOrganı).HasMaxLength(200);
		}
	}
}
