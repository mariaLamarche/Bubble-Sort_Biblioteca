using Bubble_Sort_Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Biblioteca.Implementacion_Interfaces
{
    public class ComparadorPorTitulo : IComparer<Libro>
    {
        public int Compare(Libro x, Libro y)
        {
            if (x is null || y is null)
                throw new ArgumentNullException(x is null ? nameof(x) : nameof(y), "Los libros a comparar no pueden ser nulos.");

            return string.Compare(x.Titulo, y.Titulo, StringComparison.OrdinalIgnoreCase);
        }
    }
}
