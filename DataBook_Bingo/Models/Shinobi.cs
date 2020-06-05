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

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name ="Nome: ")]
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


        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Membro: ")]
        public string Membro { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public char Nivel { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        [ForeignKey("Aldeia_Id")]
        public virtual Aldeia Aldeia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [ForeignKey("Cla_Id")]
        public virtual Clas Clas { get; set; }

    }
}
