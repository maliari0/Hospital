using App4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Entity
{
    public class HosContext : DbContext
    {
        public DbSet<doctor> doctors { get; set; }
 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Hastane;User Id=ktp;Password=ktp");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
