using GSEnterprise.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSEnterprise.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Doador> Doador { get; set; }
        public DbSet<Recebedor> Recebedor { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }

    }
}
