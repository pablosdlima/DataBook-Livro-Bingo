using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.Models
{
    [Table("Organizacao")]
    public class Organizacao
    {
        [Key]
        public int IdOrganizacao { get; set; }

        public int Limite { get; set; }

        public string NomeOrganizacao { get; set; }

        public byte[] ImgOrganizacao { get; set; }

    }
}
