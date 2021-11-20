using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSEnterprise.Models.Entidades
{
    [Table("Doador")]
    public class Doador
    {
        [Display(Description = "Id")]
        public int Id { get; set; }

        [Display(Description = "Nome")]
        public string Nome { get; set; }

        [Display(Description = "Documento")]
        public string Documento { get; set; }

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
