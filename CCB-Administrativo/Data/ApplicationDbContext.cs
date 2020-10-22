using System;
using System.Collections.Generic;
using System.Text;
using CCB_Administrativo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CCB_Administrativo.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Congregacao> Congregacoes { get; set; }
        public DbSet<Obreiro> Obreiros { get; set; }
        public DbSet<CongregacaoObreiro> CongregacoesObreiros { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}
