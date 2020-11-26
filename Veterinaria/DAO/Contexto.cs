using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Entidades;
using System.Data.Entity;

namespace Veterinaria.DAO
{
    class Contexto : DbContext
    {
        internal IEnumerable<object> Resultado;

        public Contexto() : base("conexao")
        {

        }

        public DbSet<Cliente> ObjetoCliente { get; set; }
        public DbSet<Pet> ObjetoPet { get; set; }
        public DbSet<SystemUser> ObjetoSystemUser { get; set; }
        public DbSet<Veterinario> ObjetoVeterinario { get; set; }
    }
}
/*
   1) enable-migrations
   2) Add-migration banco
   3) update-database
*/

