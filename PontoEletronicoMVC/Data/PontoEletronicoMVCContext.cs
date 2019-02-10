using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PontoEletronicoMVC.Models
{
    public class PontoEletronicoMVCContext : DbContext
    {
        public PontoEletronicoMVCContext (DbContextOptions<PontoEletronicoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PontoEletronicoMVC.Models.Usuario> Usuario { get; set; }
        public DbSet<PontoEletronicoMVC.Models.RegistroPonto> RegistroPonto { get; set; }
    }
}
