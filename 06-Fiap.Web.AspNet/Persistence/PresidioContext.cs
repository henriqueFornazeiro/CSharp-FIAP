using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Persistence
{
    public class PresidioContext: DbContext
    {
        public DbSet<Cela> Celas { get; set; }
        public DbSet<Presidiario> Presidiarios { get; set; }
        public PresidioContext(DbContextOptions o):base(o)
        {

        }

    }
}
