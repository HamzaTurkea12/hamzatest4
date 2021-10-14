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
	public class FormConfiguration : IEntityTypeConfiguration<Form>
	{
		public void Configure(EntityTypeBuilder<Form> builder)
		{
			builder.HasOne(x => x.Gender).WithMany(x => x.Forms).HasForeignKey(x => x.GenderId);
			builder.HasOne(x => x.GenelBilgiler).WithMany(x => x.Forms).HasForeignKey(x => x.GenelBilgilerId);
			builder.HasOne(x => x.JinekolojikGecmis).WithMany(x => x.Forms).HasForeignKey(x => x.JinekolojikGecmisId);
			builder.HasOne(x => x.OperasyonProseduru).WithMany(x => x.Forms).HasForeignKey(x => x.OperasyonProseduruId);
			builder.HasOne(x => x.PatolojiDurumu).WithMany(x => x.Forms).HasForeignKey(x => x.PatolojiDurumuId);
			builder.HasOne(x => x.TumorDurumu).WithMany(x => x.Forms).HasForeignKey(x => x.TumorDurumuId);
			builder.HasOne(x => x.EkIslemlerMutasyon).WithMany(x => x.Forms).HasForeignKey(x => x.EkislemlerId);
			builder.HasOne(x => x.Notlar).WithMany(x => x.Forms).HasForeignKey(x => x.NotlarId);
			builder.HasOne(x => x.SosyalYasamOzellikleri).WithMany(x => x.Forms).HasForeignKey(x => x.SosyalYasamOzellikleriId);
			builder.HasOne(x => x.SigaraKullanimi).WithMany(x => x.Forms).HasForeignKey(x => x.SigaraKullanimiId);
			builder.HasOne(x => x.AlkolKullanimi).WithMany(x => x.Forms).HasForeignKey(x => x.AlkolKullanimiId);
			builder.HasOne(x => x.MaddeKullanimi).WithMany(x => x.Forms).HasForeignKey(x => x.MaddeKullanimiId);


		}
	}
}
	
	

