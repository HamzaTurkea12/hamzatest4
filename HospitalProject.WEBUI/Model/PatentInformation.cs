using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalProject.WEBUI.Model
{
    public class PatentInformation
    {
       [Key]
       public int patentid { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public DateTime birthdate { get; set; }
        public string Sweat { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public string education_level { get; set; }


        ////////////////////////////////1.1

        public string profession { get; set; }
        public string Make_environmental_display { get; set; }
        public string condition { get; set; }
        public string medicine { get; set; }
        public int Quantity_per_day { get; set; }
        public string current_situation { get; set; }
        public DateTime date_of_publication { get; set; }

        /// <summary>
        /// /////////////////////1.2
        /// </summary>
        public string illness { get; set; }
        public string condition1 { get; set; }
        public int code { get; set; }

        public DateTime Diagnosis_date { get; set; }

        ///////////////////////////////////1.4
        ///

        public string proximity { get; set; }
        public string diagnosis { get; set; }
        public string annual_diagnosis { get; set; }

        ///////////////////////////1.5
        /// <summary>
        /// 
        /// </summary>
        public string m { get; set; }
        public string s { get; set; }
        public string a { get; set; }
        public string d { get; set; }

        ///////////////////////////1.6

        public string medicine2 { get; set; }
        public int dose { get; set; }
        public string use_cli_module { get; set; }
        public int repetition { get; set; }
        public string current_situation2 { get; set; }

        ///////////////////////////////1.7
        ///
        public string virus { get; set; }

        public string test_case { get; set; }
        public string end { get; set; }

    }
}
