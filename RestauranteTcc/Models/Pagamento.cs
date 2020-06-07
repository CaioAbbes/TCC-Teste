using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Pagamento
    {

        [Required(ErrorMessage = "Id do pagamento é obrogatorio")]
        [Display(Name = "Id do pagamento")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdPag { get; set; }

        [Required(ErrorMessage = "Id do pedido é obrogatorio")]
        [Display(Name = "Id do pedido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "Id do caixa é obrogatorio")]
        [Display(Name = "Id do caixa")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdCaixa { get; set; }

        [Required(ErrorMessage = "A forma de pagamento é obrigatorio")]
        [Display(Name = "Forma de pagamento")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string FormPag { get; set; }

        [Required(ErrorMessage = "A data e hora de pagamento é obrigatorio")]
        [Display(Name = "Data e hora do pagamento")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataHoraPag { get; set; }

        [Required(ErrorMessage = "O total a ser pago é obrigatorio")]
        [Display(Name = "Total a ser pago")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public double Total { get; set; }
    }
}