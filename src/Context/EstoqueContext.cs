using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle_de_estoque.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle_de_estoque.src.Context
{
    public class EstoqueContext : DbContext
    {

        public EstoqueContext(DbContextOptions<EstoqueContext> options) : base(options) { }

        public DbSet<EstoqueModel> Estoque { get; set; }
        public DbSet<ListaModel> Lista { get; set; }

    }
}