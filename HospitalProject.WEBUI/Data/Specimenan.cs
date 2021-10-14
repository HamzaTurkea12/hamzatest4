using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalProject.WEBUI.Model;

namespace HospitalProject.WEBUI.Data
{
    public class Specimenan :DbContext
    {
        public Specimenan(DbContextOptions<Specimenan> options) : base(options)
        {

        }
        public DbSet<Specimenanddiseaseinformation> Specimenand { get; set; }
    }
}
