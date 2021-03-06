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
	public class OperasyonProseduruConfiguration : IEntityTypeConfiguration<OperasyonProseduru>
	{
		public void Configure(EntityTypeBuilder<OperasyonProseduru> builder)
		{
			builder.Property(x => x.Description).IsRequired();
		}
	}
}
