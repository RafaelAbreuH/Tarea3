using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea3.Data;

namespace Tarea3.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes>Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SQLEXPRESS; Database = Tarea3Db; Trusted_Connection = True; ");

        }

    }
}
