using HospitalProject.DataAccess.Configurations;
using HospitalProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccess.Contexts
{
	public class HospitalContext: DbContext
	{
		public HospitalContext(DbContextOptions<HospitalContext> options): base(options)
		{
			
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AileMedikalGecmisiConfiguration());
			modelBuilder.ApplyConfiguration(new AlkolKullanimiConfiguration());
			modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
			modelBuilder.ApplyConfiguration(new AppUserConfiguration());
			modelBuilder.ApplyConfiguration(new AppUserRoleConfigurations());
			modelBuilder.ApplyConfiguration(new DonorMedikalGecmisiConfiguration());
			modelBuilder.ApplyConfiguration(new EkIslemlerConfigurations());
			modelBuilder.ApplyConfiguration(new FormAileMedikalGecmisiConfiguration());
			modelBuilder.ApplyConfiguration(new FormConfiguration());
			modelBuilder.ApplyConfiguration(new FormDonorMedikalGecmisiConfiguration());
			modelBuilder.ApplyConfiguration(new FormIlacConfiguration());
			modelBuilder.ApplyConfiguration(new FormImmunhistokimyaConfiguration());
			modelBuilder.ApplyConfiguration(new FormKanserTedavisiConfiguration());
			modelBuilder.ApplyConfiguration(new FormMetastazDurumuConfiguration());
			modelBuilder.ApplyConfiguration(new FormNumuneToplamaBilgileriConfiguration());
			modelBuilder.ApplyConfiguration(new FormTanıBilgileriConfigurations());
			modelBuilder.ApplyConfiguration(new FormViralEnfeksiyonConfiguration());
			modelBuilder.ApplyConfiguration(new GenderConfiguration());
			modelBuilder.ApplyConfiguration(new GenelBilgilerConfiguration());
			modelBuilder.ApplyConfiguration(new IlacConfiguration());
			modelBuilder.ApplyConfiguration(new ImmunhistokimyaConfigurations());
			modelBuilder.ApplyConfiguration(new JinekolojikGecmisConfigurations());
			modelBuilder.ApplyConfiguration(new KanserTedavisiConfigurations());
			modelBuilder.ApplyConfiguration(new MaddeKullanimiConfiguration());
			modelBuilder.ApplyConfiguration(new MetastazDurumuConfiguration());
			modelBuilder.ApplyConfiguration(new NotlarConfigurations());
			modelBuilder.ApplyConfiguration(new NumuneToplamaBilgileriConfiguration());
			modelBuilder.ApplyConfiguration(new OperasyonProseduruConfiguration());
			modelBuilder.ApplyConfiguration(new PatolojiDurumuConfiguration());
			modelBuilder.ApplyConfiguration(new SigaraKullanimiConfiguration());
			modelBuilder.ApplyConfiguration(new SosyalYasamOzellikleriConfiguration());
			modelBuilder.ApplyConfiguration(new TaniBilgileriConfiguration());
			modelBuilder.ApplyConfiguration(new TumorDurumuConfiguration());
			modelBuilder.ApplyConfiguration(new ViralEnfeksiyonlarConfiguration());


		}


		public DbSet<AileMedikalGecmisi> AileMedikalGecmisis { get; set; }
		public DbSet<AlkolKullanimi> AlkolKullanimis { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppUserRole> AppUserRoles { get; set; }
		public DbSet<DonorMedikalGecmisi> DonorMedikalGecmisis { get; set; }
		public DbSet<EkIslemlerMutasyon> EkIslemlerMutasyons { get; set; }
		public DbSet<Form> Forms { get; set; }
		public DbSet<FormAileMedikalGecmisi> FormAileMedikalGecmisis { get; set; }
		public DbSet<FormDonorMedikalGecmisi> FormDonorMedikalGecmisis { get; set; }
		public DbSet<FormIlac> FormIlacs { get; set; }
		public DbSet<FormImmunhistokimya> FormImmunhistokimyas { get; set; }
		public DbSet<FormKanserTedavisi> FormKanserTedavisis { get; set; }
		public DbSet<FormMetastazDurumu> FormMetastazDurumus { get; set; }
		public DbSet<FormNumuneToplamaBilgileri> FormNumuneToplamaBilgileris { get; set; }
		public DbSet<FormTanıBilgileri>	FormTanıBilgileris { get; set; }
		public DbSet<FormViralEnfeksiyon> FormViralEnfeksiyons { get; set; }
		public DbSet<Gender> Genderd { get; set; }
		public DbSet<GenelBilgiler> GenelBilgilers { get; set; }
		public DbSet<Ilac> Ilacs { get; set; }
		public DbSet<ImmunhistokimyaTest> ImmunhistokimyaTests { get; set; }
		public DbSet<JinekolojikGecmis>	jinekolojikGecmiss { get; set; }
		public DbSet<KanserTedavisi> KanserTedavisis { get; set; }
		public DbSet<MaddeKullanimi> MaddeKullanimis { get; set; }
		public DbSet<MetasazDurumu> MetasazDurumus { get; set; }
		public DbSet<Notlar> Notlars { get; set; }
		public DbSet<FormNumuneToplamaBilgileri> NumuneToplamaBilgileris { get; set; }
		public DbSet<OperasyonProseduru> OperasyonProsedurus { get; set; }
		public DbSet<PatolojiDurumu> PatolojiDurumus { get; set; }
		public DbSet<SigaraKullanimi> SigaraKullanimis { get; set; }
		public DbSet<SosyalYasamOzellikleri> SosyalYasamOzellikleris { get; set; }
		public DbSet<TaniBilgileri> TaniBilgileris { get; set; }
		public DbSet<TumorDurumu> TumorDurumus { get; set; }
		public DbSet<ViralEnfeksiyon> ViralEnfeksiyons { get; set; }

	}
}
