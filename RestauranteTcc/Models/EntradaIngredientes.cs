using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class EntradaIngredientes
    {
        [Required(ErrorMessage = "Id entrada pagamento é obrigatorio")]
        [Display(Name = "Id entrada pagamento")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int idEntradaIngre { get; set; }

        [Required(ErrorMessage = "O codigo de barras é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Código de barras")]
        [Range(13, 13, ErrorMessage = "Numero de caracteres errada")]
        public int CodigoBarras { get; set; }

        [Required(ErrorMessage = "Quantidade entrada ingrediente é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Quantidade entrada ingrediente")]
        public int QtdEntraIngre { get; set; }

        [Required(ErrorMessage = "A data e hora de pagamento é obrigatorio")]
        [Display(Name = "Data e hora do pagamento")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataHoraChegada { get; set; }

    }
}