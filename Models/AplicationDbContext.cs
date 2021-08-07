using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguroMundial3.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {



        }

        public DbSet<Area> Areas{ get; set; }
        public DbSet<Estado> Estados { get; set; }
      

        public DbSet<Tecnico> Tecnicos{ get; set; }
        public DbSet<Impresora> Impresoras { get; set; }
        public DbSet<Historial> Historials { get; set; }
        public DbSet<Tipo> Tipos{ get; set; }
    }
}
