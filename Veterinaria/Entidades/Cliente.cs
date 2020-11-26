using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Entidades
{
    class Cliente
    {
       // public int IdUsuario { get; set; }
        public string NomeComp { get; set; }
        [Key]
        public string RgUsuario { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }
    }
}
