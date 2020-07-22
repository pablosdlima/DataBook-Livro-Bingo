using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.ViewModel
{
    public class ClasViewModel
    {
        [Required(ErrorMessage = "O campo é Obrigátorio")]
        [Display(Name = "Nome: ")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos.")]
        public string NomeClas { get; set; }

        [Display(Name = "Imagem: ")]
        public byte[] ImageClas { get; set; }
    }
}
