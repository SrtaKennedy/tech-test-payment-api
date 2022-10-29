using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APITESTE2.Entities;

namespace APITESTE2.Context
{
    public class VendaContext : DbContext
    {
        public VendaContext(DbContextOptions<VendaContext> options) : base(options)
        {

        }

        public DbSet<Venda> Vendas{ get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

    }
}