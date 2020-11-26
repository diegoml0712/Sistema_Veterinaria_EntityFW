using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    class Veterinario
    {
        [Key]
        public int IdVeterinario { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Especialidade { get; set; }
    }
}
