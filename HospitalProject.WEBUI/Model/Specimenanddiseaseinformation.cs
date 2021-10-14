using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalProject.WEBUI.Model
{
    public class Specimenanddiseaseinformation
    {
        public DateTime collection_date { get; set; }
        [Key]
        public int collection_time { get; set; }

        public string anatomical_region { get; set; }
        public string group_type { get; set; }

        /////////////////////////////////2.2
        /// <summary>
        /// 
        /// </summary>
        public string OPERASYON_PROSEDÜRÜ {get;set;}
        ///////////////////////////////2.3



        ////////////////////////////////////2.4

        public DateTime Diagnosis_date { get; set; }
        public string Clinical_diagnosis { get; set; }

        public int Diagnotstic_Code { get; set; }

        public string Numune_To_lama_ekli { get; set; }
        public string Mikroskopik_analize { get; set; }
        public string patolojik_tani { get; set; }

    }
}
