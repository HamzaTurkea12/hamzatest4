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
	public class JinekolojikGecmisConfigurations : IEntityTypeConfiguration<JinekolojikGecmis>
	{
		public void Configure(EntityTypeBuilder<JinekolojikGecmis> builder)
		{
			builder.Property(x => x.MenstüralDurum).HasMaxLength(200);
			//builder.Property(x => x.SonReglTarihi).HasDefaultValueSql("getdate()");
			builder.Property(x => x.Hamilelikler).HasMaxLength(50);
			builder.Property(x => x.Dogumlar).HasMaxLength(50);


		}
	}
}
