using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Caixa
    {
        [Required(ErrorMessage = "Id do caixa é obrigatário")]
        [Display(Name = "Id do caixa")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdCaixa { get; set; }

        [Required(ErrorMessage = "CPF do funcionario é obrigatorio")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "CPF do funcionário")]
        [Range(11, 11, ErrorMessage = "Numero de caracteres do CPF invalido")]
        public int CPFfunc { get; set; }

    }
}