using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSEnterprise.Models.Entidades
{
    [Table("Recebedor")]
    public class Recebedor
    {
        [Display(Description = "Id")]
        public int Id { get; set; }

        [Display(Description = "Instituição")]
        public string Instituicao { get; set; }

        [Display(Description = "CNPJ")]
        public string Cnpj { get; set; }

        [Display(Description = "Email")]
        public string Email { get; set; }

        [Display(Description = "Telefone")]
        public string Telefone { get; set; }

        [Display(Description = "Endereço")]
        public string Endereco { get; set; }

        [Display(Description = "Número")]
        public string Numero { get; set; }

        [Display(Description = "Bairro")]
        public string Bairro { get; set; }

        [Display(Description = "Cidade")]
        public string Cidade { get; set; }

        [Display(Description = "Estado")]
        public string Estado { get; set; }

        [Display(Description = "CEP")]
        public string Cep { get; set; }
    }
}
