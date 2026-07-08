using Bubble_Sort_Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Biblioteca.Interfaces
{
    public interface ICatalogoLibros
    {
        List<Libro> ObtenerTodos();
    }
}
