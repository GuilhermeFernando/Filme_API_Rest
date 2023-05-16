using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.DTOs
{
    public class UpdateFilmeDto

    {    

        [Required(ErrorMessage = "O titulo do filme e obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O genero do filme e obrigatorio")]
        [StringLength(50, ErrorMessage = "O tamanho do g�nero n�o pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Obrigat�rio colocar nome do diretor do filme")]
        [MaxLength(50)]
        public string Diretor { get; set; }

        [Required]
        [Range(70, 600, ErrorMessage = "A dura��o deve ser entre 70 a 600 minitos")]
        public int Duracao { get; set; }



    }
}