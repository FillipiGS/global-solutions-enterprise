using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSEnterprise.Models.Entidades
{
    [Table("Solicitacao")]
    public class Solicitacao
    {
        [Display(Description = "Id")]
        public int Id { get; set; }

        [Display(Description = "Instituição")]
        public string Instituicao { get; set; }

        [Display(Description = "Email")]
        public string Email { get; set; }

        [Display(Description = "Telefone")]
        public string Telefone { get; set; }

        [Display(Description = "Endereço")]
        public string Endereco { get; set; }

        [Display(Description = "CNPJ")]
        public string Cnpj { get; set; }

        [Display(Description = "Alimento")]
        public string Alimento { get; set; }

        [Display(Description = "Descrição")]
        public string Descricao { get; set; }
    }
}
