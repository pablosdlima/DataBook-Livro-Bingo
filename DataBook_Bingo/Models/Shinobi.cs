using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.Models
{
    [Table ("Shinobi")]
    public class Shinobi
    {
        [Key]
        public int IdShinobi { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Aldeia:")]
        public int Aldeia_Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Clã: ")]
        public int Cla_Id { get; set; }

        [Display(Name = "Organização: ")]
        public int Organizacao_Id { get; set; }

        public string NomeShinobi { get; set; }

        public byte[] ImagemShinobi { get; set; }
        
        public string Especialidade { get; set; }
        
        public char Renegado { get; set; }
        
        public char Vivo { get; set; }
        
        public string Elemento { get; set; }

        public string Graduacao { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        [ForeignKey("Aldeia_Id")]
        public virtual Aldeia Aldeia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [ForeignKey("Cla_Id")]
        public virtual Clas Clas { get; set; }

        [ForeignKey("Organizacao_Id")]
        public virtual Organizacao Organizacao { get; set; }

    }
}
