using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Estoque
    {
        [Required(ErrorMessage = "O codigo de barras é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Código de barras")]
        [Range(13,13,ErrorMessage = "Numero de caracteres errada")]
        public int CodigoBarras { get; set; }

        [Required(ErrorMessage = "O Id do fornecedor é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Id do fornecedor")]
        public int idForn { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Unidade de medida é orbigatório")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        [Display(Name = "Unidade de medida ")]
        public string UniMedi { get; set; }

        [Required(ErrorMessage = "O preço unitário é obrigatório")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "Preço unitário")]
        public double PrecoUnit { get; set; }

        [Required(ErrorMessage = "A quantidade atual é obrigatória")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Display(Name = "A quantidade atual")]
        public int QtdAtual { get; set; }

    }
}