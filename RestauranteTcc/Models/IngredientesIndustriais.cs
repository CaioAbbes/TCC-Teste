using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class IngredientesIndustriais
    {
        [Required(ErrorMessage = "Numeros de ingredientes é obrigatório")]
        [Display(Name = "Numeros de ingredientes")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int NumIngrez { get; set; }

        [Required(ErrorMessage = "O codigo de barras é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Código de barras")]
        [Range(13, 13, ErrorMessage = "Numero de caracteres errada")]
        public int CodigoBarras { get; set; }

        [Required(ErrorMessage = "A data de validade é obrigatoria")]
        [Display(Name = "Data de validade")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "Marca é obrigatorio")]
        [Display(Name = "Marca")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string Marca { get; set; }
    }
}