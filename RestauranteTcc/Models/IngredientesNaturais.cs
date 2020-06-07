using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class IngredientesNaturais
    {

        [Required(ErrorMessage = "Numero de ingredientes é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Numero de ingredientes")]
        public int NumIngre { get; set; }

        [Required(ErrorMessage = "O codigo de barras é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Código de barras")]
        [Range(13, 13, ErrorMessage = "Numero de caracteres errada")]
        public int CodigoBarras { get; set; }

        [Required(ErrorMessage = "Tempo de duração é obrigatorio")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Tempo de duração")]
        public string TempDura { get; set; }
    }
}