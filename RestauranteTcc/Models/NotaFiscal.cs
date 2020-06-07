using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class NotaFiscal
    {

        [Required(ErrorMessage = "Id nota fiscal é obrigatorio")]
        [Display(Name = "Id nota fiscal")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int idNF { get; set; }


        [Required(ErrorMessage = "Id entrada pagamento é obrigatorio")]
        [Display(Name = "Id entrada pagamento")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdPag { get; set; }

        [Required(ErrorMessage = "A data e hora de pagamento é obrigatorio")]
        [Display(Name = "Data e hora do pagamento")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataHoraPag { get; set; }

        [Required(ErrorMessage = "O total a ser pago é obrigatorio")]
        [Display(Name = "Total a ser pago")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public double ValorTotal { get; set; }
    }
}