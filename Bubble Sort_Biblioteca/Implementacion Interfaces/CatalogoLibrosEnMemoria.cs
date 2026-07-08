using Bubble_Sort_Biblioteca.Entidades;
using Bubble_Sort_Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Biblioteca.Implementacion_Interfaces
{
    public class CatalogoLibrosEnMemoria : ICatalogoLibros
    {
        public List<Libro> ObtenerTodos()
        {
            return new List<Libro>
            {
                new Libro(1, "Don Quijote de la Mancha", "Miguel de Cervantes"),
                new Libro(2, "Cien años de soledad", "Gabriel García Márquez"),
                new Libro(3, "La metamorfosis", "Franz Kafka"),
                new Libro(4, "El principito", "Antoine de Saint-Exupéry"),
                new Libro(5, "Rayuela", "Julio Cortázar"),
                new Libro(6, "Ficciones", "Jorge Luis Borges")
            };
        }
    }
}
