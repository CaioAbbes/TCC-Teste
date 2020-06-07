using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Endereco
    {
        [Required(ErrorMessage = "CEP é obrigatorio")]
        [Display(Name = "CEP")]
        [Range(8,8,ErrorMessage = "Numero de caracteres invalido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int CEP { get; set; }

        [Required(ErrorMessage = "Logra é obrigatorio")]
        [Display(Name = "Logradouro")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string Logra { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatorio")]
        [Display(Name = "Bairro")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatorio")]
        [Display(Name = "Cidade")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatorio")]
        [Display(Name = "Estado")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "UF é obrigatorio")]
        [Display(Name = "UF")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public char UF { get; set; }
    }
}