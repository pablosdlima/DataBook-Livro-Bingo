using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.ViewModel
{
    public class ShinobiViewModel
    {
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Aldeia:")]
        public int Aldeia_Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Clã: ")]
        public int Cla_Id { get; set; }

        [Display(Name = "Organização: ")]
        public int Organizacao_Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos.")]
        [Display(Name = "Nome: ")]
        public string NomeShinobi { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Imagem: ")]
        public byte[] ImagemShinobi { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Especialidade: ")]
        public string Especialidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Renegado?: ")]
        public char Renegado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Vivo?: ")]
        public char Vivo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Elemento Principal: ")]
        public string Elemento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Graduação: ")]
        public string Graduacao { get; set; }

    }
}
