using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Fornecedor
    {
        [Required(ErrorMessage = "Id nota fiscal é obrigatorio")]
        [Display(Name = "Id nota fiscal")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdForn { get; set; }

        [Required(ErrorMessage = "A razão social é obrigatoria")]
        [Display(Name = "Razão social")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "A razão social é obrigatoria")]
        [Display(Name = "Razão social")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string NomeForn { get; set; }

        [Required(ErrorMessage = "CNPJ é obrigatório")]
        [Display(Name = "CNPJ")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Range(11, 11, ErrorMessage = "Numero de caracteres do CNPJ invalido")]
        public int CNPJ { get; set; }
        public int CEP { get; set; }
        public int Tel { get; set; }
        public string EmailForn { get; set; }
        public string Comp { get; set; }
        public int NumEdif { get; set; }
        
    }
}