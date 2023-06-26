using FilmesAPI.Data.DTOs;
using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {

        }

        public DbSet<Filme> Filmes { get; set; }
         public DbSet<Cinema> Cinemas { get; set; }

    }
}