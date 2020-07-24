using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.ViewModel
{
    public class CadastroViewModel
    {

        [Required(ErrorMessage = "Informe seu E-mail")]
        [MaxLength(100, ErrorMessage = "O Login deve ter até 100")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimo 6 digitos.")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare(nameof(Senha), ErrorMessage = "As senhas não conhecidem")]
        public string ConfirmaSenha { get; set; }
    }
}
