//Clase lector
using System;
using System.Collections.Generic;

namespace Colecciones
{
    internal class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> librosEnPrestamo;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.librosEnPrestamo = new List<Libro>();
        }

        public string GetDni()
        {
            return dni;
        }

        public int GetCantidadPrestamos()
        {
            return librosEnPrestamo.Count;
        }

        public bool AgregarLibro(Libro libro)
        {
            if(librosEnPrestamo.Count >= 3)
            {
                return false, //limite alcanzado
            }
            librosEnPrestamo.Add(libro);
            return true, //prestamo exitoso
        }

        public override string ToString()
        {
            return $"Lector:{nombre} | DNI:{dni} | Libros Prestados{librosEnPrestamo.Count}";
        }
    }
}


