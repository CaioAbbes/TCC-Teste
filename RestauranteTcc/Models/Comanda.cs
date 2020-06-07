using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Comanda
    {
        [Required(ErrorMessage = "Id comanda é obrigatorio")]
        [Display(Name = "Id comanda")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdComanda { get; set; }

        [Required(ErrorMessage = "CPF do cliente é obrigatório")]
        [Display(Name = "CPF do cliente")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Range(11, 11, ErrorMessage = "Numero de caracteres do CPF invalido")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "Status comanda é obrigatorio")]
        [Display(Name = "Status comanda")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string StatsComan { get; set; }

        [Required(ErrorMessage = "A data e hora comanda é obrigatorio")]
        [Display(Name = "A data e hora comanda")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataHComan { get; set; }

    }
}