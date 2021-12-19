using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Estera_Horoba_Lab5.Models;

namespace Estera_Horoba_Lab5.Data
{
    public class Estera_Horoba_Lab5Context : DbContext
    {
        public Estera_Horoba_Lab5Context (DbContextOptions<Estera_Horoba_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Estera_Horoba_Lab5.Models.Book> Book { get; set; }

        public DbSet<Estera_Horoba_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Estera_Horoba_Lab5.Models.Category> Category { get; set; }
    }
}
