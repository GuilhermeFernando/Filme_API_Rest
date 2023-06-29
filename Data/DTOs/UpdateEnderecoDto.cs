using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.DTOs
{
    public class UpdateEnderecoDto
    {
        [Required]
        public string Logradouro { get; set; }
        
        [Required]
        public int Numero { get; set; }
    }
}