using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web1.Models;

namespace web1.services
{
    public class PeliculasServices
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Plan de Escape",
                Duracion = 115,
                Pais = "USA",
                Publicacion =new DateTime(2013,12,5)

            };
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Plan de Escape",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Capitan America",
                Duracion = 147,
                Pais = "USA",
                Publicacion = new DateTime(2016, 04, 29)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}