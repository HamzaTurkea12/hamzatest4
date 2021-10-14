using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Data
{
    public class PatentContext : DbContext
    {
        public PatentContext(DbContextOptions<PatentContext> options):base(options)
        {

        }
        public DbSet<PatentInformation> Patents { get; set; }

    }
}
