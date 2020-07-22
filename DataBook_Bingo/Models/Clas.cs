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

        public string NomeClas { get; set; }

        public byte[] ImageClas { get; set; }
    }
}
