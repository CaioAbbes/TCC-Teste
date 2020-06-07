using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class ProdutoPedido
    {
        [Required(ErrorMessage = "Id produto pedido é obrigatorio")]
        [Display(Name = "Id produto pedido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdProdPed { get; set; }

        [Required(ErrorMessage = "Id produto é obrigatorio")]
        [Display(Name = "Id produto")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdProd { get; set; }

        [Required(ErrorMessage = "CPF do cliente é obrigatório")]
        [Display(Name = "CPF do cliente")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Range(11, 11, ErrorMessage = "Numero de caracteres do CPF invalido")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "Id comanda é obrigatorio")]
        [Display(Name = "Id comanda")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdComanda { get; set; }

        [Required(ErrorMessage = "O nome produto é obrigatorio")]
        [Display(Name = "Nome produto")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        [Range(3, 100)]
        public string NomeProd { get; set; }

        [Required(ErrorMessage = "A quantidade do produto é obrigatoria")]
        [Display(Name = "A quantidade do produto")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int QtdProd { get; set; }

        [Required(ErrorMessage = "O valor unitário do produto é obrigatorio")]
        [Display(Name = "Valor unitário do produto")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public double ValorUnitProd { get; set; }

        [Required(ErrorMessage = "O estagio do produto é obrigatorio")]
        [Display(Name = "Estagio do produto")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string StagioProd { get; set; }

        [Required(ErrorMessage = "A data e hora do produto pedido é obrigatorio")]
        [Display(Name = "Data e hora do produto pedido")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataHProdPed { get; set; }
    }
}