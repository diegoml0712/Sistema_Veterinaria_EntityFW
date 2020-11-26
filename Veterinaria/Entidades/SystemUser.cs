using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    class SystemUser
    {
        [Key]
        public int IdUsuario { get; set; }
        public string RgUsuario { get; set; }
        public string NomeComp { get; set; }
        public string senha { get; set; }
        public string Cargo { get; set; }
    }
}
