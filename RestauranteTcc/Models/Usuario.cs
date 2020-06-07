using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="O id do usuario é obrigatorio")]
        [Display(Name ="Id do usuário")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O nome do usuario é obrigatorio")]
        [Display(Name = "Nome do usuario")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        [Range(3,100)]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "A senha do usuario é obrigatorio")]
        [Display(Name = "Senha do usuario")]
        public string Senha { get; set; }




        //[Required(ErrorMessage = "CPF do funcionario é obrigatorio")]
        //[RegularExpression(@"^((\d{3}).(\d{3}).(\d{3})-(\d{2}))*$", ErrorMessage = "Digite um CPF valido")]
        //[Display(Name = "CPF do funcionário")]
        //[Range(11, 11, ErrorMessage = "Numero de caracteres do CPF invalido")]
        //public int CPFfunc { get; set; }


    }
}