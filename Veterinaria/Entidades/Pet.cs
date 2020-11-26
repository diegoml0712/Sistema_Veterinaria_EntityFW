using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    class Pet
    {
        [Key]
        public int IdPet { get; set; }
        public string NomePet { get; set; }
        public DateTime Nascimento { get; set; }

       
        public string RgUsuario { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public DateTime UltimaConsulta { get; set; }
        public DateTime ProximaConsulta { get; set; }
        public string Historico { get; set; }
        public string RgVet { get; set; }
        
    }
}
