using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities
{
	public class Form : BaseEntity
	{
		//hangi kullanıcı
		//kullanıcının adı soyadı 
		//formun kendisi

		//public int HastaBilgileriId { get; set; }
		//public HastaBilgileri HastaBilgileri { get; set; }

		//public int NumuneBilgisivePatolojiDurumuId { get; set; }
		//public NumuneBilgisivePatolojiDurumu NumuneBilgisivePatolojiDurumu { get; set; }

		//public KanserBilgileriId { get; set; }
	 //   public KanerBilgileri KanserBilgileri { get; set; }

		public int GenelBilgilerId { get; set; }
		public GenelBilgiler GenelBilgiler { get; set; }

		public int JinekolojikGecmisId { get; set; }
		public JinekolojikGecmis JinekolojikGecmis { get; set; }

		public int OperasyonProseduruId { get; set; }
		public OperasyonProseduru OperasyonProseduru { get; set; }

		public int PatolojiDurumuId { get; set; }
		public PatolojiDurumu PatolojiDurumu { get; set; }

		public int TumorDurumuId { get; set; }
		public TumorDurumu TumorDurumu { get; set; }

		public int EkislemlerId { get; set; }
		public EkIslemlerMutasyon EkIslemlerMutasyon { get; set; }

		public int NotlarId { get; set; }
		public Notlar Notlar { get; set; }

		public int GenderId { get; set; }
		public Gender Gender { get; set; }

		public int SosyalYasamOzellikleriId { get; set; }
		public SosyalYasamOzellikleri SosyalYasamOzellikleri { get; set; }

		public int SigaraKullanimiId { get; set; }
		public SigaraKullanimi SigaraKullanimi { get; set; }
		
		public int AlkolKullanimiId { get; set; }
		public AlkolKullanimi AlkolKullanimi { get; set; }


		public int MaddeKullanimiId { get; set; }
		public MaddeKullanimi MaddeKullanimi { get; set; }







		public List<FormImmunhistokimya> FormImmunhistokimyas { get; set; }
		public List<FormKanserTedavisi> FormKanserTedavisis { get; set; }
		public List<FormMetastazDurumu> FormMetastazDurumus { get; set; }
		public List<FormTanıBilgileri> FormTanıBilgileris { get; set; }
		public List<FormNumuneToplamaBilgileri> FormNumuneToplamaBilgileris { get; set; }
		public List<FormViralEnfeksiyon> FormViralEnfeksiyons { get; set; }
		public List<FormIlac> FormIlacs { get; set; }
		public List<FormAileMedikalGecmisi> FormAileMedikalGecmisis { get; set; }
		public List<FormDonorMedikalGecmisi> FormDonorMedikalGecmisis { get; set; }
		public List<AppUser> AppUsers { get; set; }
	}
}
