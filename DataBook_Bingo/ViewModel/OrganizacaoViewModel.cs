using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBook_Bingo.ViewModel
{
    public class OrganizacaoViewModel
    {
        [Display(Name = "Limite de Integrantes: ")]
        public int Limite { get; set; }

        [Required]
        [Display(Name = "Nome: ")]
        public string NomeOrganizacao { get; set; }
     
        [Display(Name = "Imagem: ")]
        public byte[] ImgOrganizacao { get; set; }
    }
}
