using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.Models
{
    [Table("Aldeia")]
    public class Aldeia
    {
        [Key]
        public int IdAldeia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Aldeia: ")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos.")]
        public string NomeAldeia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Imagem: ")]
        public byte[] ImgAldeia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("País: ")]
        public string PaisAldeia { get; set; }
    }
}
