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

        public string NomeAldeia { get; set; }

        public byte[] ImgAldeia { get; set; }

        public string PaisAldeia { get; set; }
    }
}
