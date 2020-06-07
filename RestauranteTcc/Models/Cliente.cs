using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Cliente
    {

        [Required(ErrorMessage = "CPF do funcionário é obrigatório")]
        [Display(Name = "CPF do funcionário")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Range(11, 11, ErrorMessage = "Numero de caracteres do CPF invalido")]

        public int CPFCli { get; set; }

        [Required(ErrorMessage = "CEP do funcionário é obrigatório")]
        [Display(Name = "CEP do funcionário")]
        [Range(8, 8, ErrorMessage = "Numero de caracteres invalido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int CEPCli { get; set; }

        [Required(ErrorMessage = "O nome do funcionário é obrigatorio")]
        [Display(Name = "Nome do funcionário")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Range(3, 100)]
        public string NomeCli { get; set; }

        [Required(ErrorMessage = "O email do funcionário é obrigatorio")]
        [Display(Name = "E-mail do funcionário")]
        [RegularExpression(@"^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Email inválido")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A quantidade de caracteres está errada")]
        public string EmailCli { get; set; }

        [Display(Name = "Celular do cliente")]
        [Range(9, 9, ErrorMessage = "Numero de caracteres do cliente invalido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int CelCli { get; set; }

        [Display(Name = "Complemento do cliente")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string Comp { get; set; }

        [Required(ErrorMessage = "Numero do edificio do cliente é obrigatorio")]
        [Display(Name = "Numero do edificio do cliente")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int NumEdif { get; set; }

    }
}