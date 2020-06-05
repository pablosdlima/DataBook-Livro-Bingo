using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.Models
{
    [Table("Cla")]
    public class Clas
    {
        [Key]
        public int IdClas { get; set; }

        [Required(ErrorMessage = "O campo é Obrigátorio")]
        [Display(Name = "Nome: ")]
        public string NomeClas { get; set; }

        [Required(ErrorMessage = "O campo é Obrigátorio")]
        [Display(Name = "Imagem: ")]
        public byte[] ImageClas { get; set; }
    }
}
