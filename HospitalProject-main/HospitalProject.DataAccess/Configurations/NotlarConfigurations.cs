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
	public class NotlarConfigurations : IEntityTypeConfiguration<Notlar>
	{
		public void Configure(EntityTypeBuilder<Notlar> builder)
		{
			builder.Property(x => x.Description).HasMaxLength(900);
		}
	}
}
