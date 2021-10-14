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
	public class FormTanıBilgileriConfigurations : IEntityTypeConfiguration<FormTanıBilgileri>
	{
		public void Configure(EntityTypeBuilder<FormTanıBilgileri> builder)
		{
			builder.HasIndex(x => new
			{
				x.FormId,
				x.TaniBilgileriId

			}).IsUnique();

			builder.HasOne(x => x.Form).WithMany(x => x.FormTanıBilgileris).HasForeignKey(x => x.FormId);
			builder.HasOne(x => x.TaniBilgileri).WithMany(x => x.FormTanıBilgileris).HasForeignKey(x => x.TaniBilgileriId);
		}
	}
}
