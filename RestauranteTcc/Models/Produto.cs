using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Id do produto é obrigatorio")]
        [Display(Name = "Id do produto")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdProd { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatorio")]
        [Display(Name = "Nome do produto")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        [Range(3,40)]
        public string NomeProd { get; set; }

        [Required(ErrorMessage = "Valor do produto é obrigatorio")]
        [Display(Name = "Valor do produto")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public double ValorProd { get; set; }

        [Required(ErrorMessage = "Descrição do produto é obrigatorio")]
        [Display(Name = "Descrição do produto")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string DescProd { get; set; }
    }
}