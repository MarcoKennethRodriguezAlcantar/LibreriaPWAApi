using LibreriaPWA.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaPWA.Api.Service
{
    public class LibrosService : ILibrosService
    {
        public LibreriaContext _libreriaDbContext;

        public LibrosService(LibreriaContext libreriaDbContext)
        {
            _libreriaDbContext = libreriaDbContext;
        }

        #region Metodos
        public Libros AddLibro(Libros libro)
        {
            _libreriaDbContext.Libros.Add(libro);
            _libreriaDbContext.SaveChanges();
            return libro;
        }

        public List<Libros> GetLibros()
        {
            return _libreriaDbContext.Libros.ToList();
        }

        public void UpdateLibro(Libros libro)
        {
            _libreriaDbContext.Libros.Update(libro);
            _libreriaDbContext.SaveChanges();
        }

        public void DeleteLibro(int id)
        {
            Libros libro = _libreriaDbContext.Libros.FirstOrDefault(x => x.Id == id);
            if(libro != null)
            {
                _libreriaDbContext.Remove(libro);
                _libreriaDbContext.SaveChanges();
            }
        }

        public Libros GetLibro(int id)
        {
            return _libreriaDbContext.Libros.FirstOrDefault(x => x.Id == id);
        }
        #endregion
    }
}
