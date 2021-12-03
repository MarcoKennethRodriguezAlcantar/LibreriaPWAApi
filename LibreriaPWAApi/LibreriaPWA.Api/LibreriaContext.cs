using LibreriaPWA.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPWA.Api
{
    public class LibreriaContext : DbContext
    {
        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options)
        {

        }

        public DbSet<Libros> Libros { get; set; } 
    }
}