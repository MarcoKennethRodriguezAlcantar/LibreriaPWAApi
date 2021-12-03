using System;
using System.ComponentModel.DataAnnotations;

namespace LibreriaPWA.Api.Model
{
    public class Libros
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Paginas { get; set; }
        public DateTime  anioEdicion {get; set;}
        public bool Activo { get; set; }
    }
}
