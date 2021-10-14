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
	public class KanserTedavisiConfigurations : IEntityTypeConfiguration<KanserTedavisi>
	{
		public void Configure(EntityTypeBuilder<KanserTedavisi> builder)
		{
			builder.Property(x => x.TedaviTipi).HasMaxLength(200);
		}
	}
}
