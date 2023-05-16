using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O t�tulo do filme � obrigat�rio")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "O g�nero do filme � obrigat�rio")]
    [MaxLength(50, ErrorMessage = "O tamanho do g�nero n�o pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "Obrigat�rio colocar nome do diretor do filme")]
    [MaxLength(50)]
    public string Diretor { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "A dura��o deve ser entre 70 a 600 minitos")]
    public int Duracao { get; set; }


    
}