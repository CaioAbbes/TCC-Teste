using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteTcc.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "CPF do funcionário é obrigatório")]
        [Display(Name = "CPF do funcionário")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Range(11, 11, ErrorMessage = "Numero de caracteres do CPF invalido")]
        public int CPFfunc { get; set; }

        [Required(ErrorMessage = "CEP do funcionário é obrigatório")]
        [Display(Name = "CEP do funcionário")]
        [Range(8, 8, ErrorMessage = "Numero de caracteres invalido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int CEP { get; set; }

        [Required(ErrorMessage = "O nome do funcionário é obrigatorio")]
        [Display(Name = "Nome do funcionário")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        [Range(3, 100)]
        public string NomeFunc { get; set; }

        [Required(ErrorMessage = "A data do funcionário é obrigatorio")]
        [Display(Name = "Data do funcionário")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DatNascFunc { get; set; }

        [Required(ErrorMessage = "O cargo do funcionário é obrigatorio")]
        [Display(Name = "Cargo do funcionário")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string CargoFunc { get; set; }

        [Required(ErrorMessage = "O sexo do funcionário é obrigatorio")]
        [Display(Name = "Sexo do funcionário")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public char SexoFunc { get; set; }

        [Display(Name = "Telefone do funcionário")]
        [Range(9, 9, ErrorMessage = "Numero de caracteres do RG invalido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int TelFunc { get; set; }

        [Display(Name = "Celular do funcionário")]
        [Range(9, 9, ErrorMessage = "Numero de caracteres do cliente invalido")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int CelFunc { get; set; }

        [Required(ErrorMessage = "O email do funcionário é obrigatorio")]
        [Display(Name = "E-mail do funcionário")]
        [RegularExpression(@"^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Email inválido")]
        [StringLength(100,MinimumLength = 5,ErrorMessage = "A quantidade de caracteres está errada")]
        public string EmailFunc { get; set; }

        [Required(ErrorMessage = "O RG do funcionário é obrigatorio")]
        [Display(Name = "RG do funcionário")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        [Range(9,9,ErrorMessage = "Numero de caracteres do RG invalido")]
        public int RgFunc { get; set; }

        [Display(Name = "Complemento")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digite somente letras")]
        public string Comp { get; set; }

        [Required(ErrorMessage = "Numero do edificio do funcionário é obrigatorio")]
        [Display(Name = "Numero do edificio do funcionário")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Digite somente numeros")]
        public int NumEdif { get; set; }

    }
}