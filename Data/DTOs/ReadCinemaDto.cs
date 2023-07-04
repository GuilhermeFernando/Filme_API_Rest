using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.DTOs
{
    public class ReadCinemaDto
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto Endereco {get;set;}
    }
}