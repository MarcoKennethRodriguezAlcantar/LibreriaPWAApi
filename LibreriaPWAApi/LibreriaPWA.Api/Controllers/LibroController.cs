using LibreriaPWA.Api.Model;
using LibreriaPWA.Api.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibreriaPWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibrosService _librosService;

        public LibroController(ILibrosService librosService)
        {
            _librosService = librosService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Libro/Alive")]
        public IActionResult Alive()
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Libro/GetLibros")]
        public IEnumerable<Libros> GetLibros()
        {
            return _librosService.GetLibros();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Libro/AddLibro")]
        public IActionResult AddLibro(Libros libros)
        {
            _librosService.AddLibro(libros);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Libro/UpdateLibro")]
        public IActionResult UpdateLibro(Libros libros)
        {
            _librosService.UpdateLibro(libros);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Libro/DeleteLibro")]
        public IActionResult DeleteLibro(int id)
        {
            Libros existeLibro = _librosService.GetLibro(id);
            if(existeLibro != null)
            {
                _librosService.DeleteLibro(id);
                return Ok();
            }
            return NotFound("El libro con el Id: " + id + " no existe.");
        }

        [HttpGet]
        [Route("GetLibro")]
        public Libros GetLibro(int id)
        {
            return _librosService.GetLibro(id);
        }
    }
}
