using LibreriaPWA.Api.Model;
using System.Collections.Generic;

namespace LibreriaPWA.Api.Service
{
    public interface ILibrosService
    {
        Libros AddLibro(Libros libro);
        List<Libros> GetLibros();
        void UpdateLibro(Libros libro);
        void DeleteLibro(int id);
        Libros GetLibro(int id);
    }
}
