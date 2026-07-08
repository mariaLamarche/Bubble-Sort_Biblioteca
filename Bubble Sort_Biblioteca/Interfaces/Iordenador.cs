using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Biblioteca.Interfaces
{
    public interface Iordenador <T>
    {
        void Ordenar(List<T> lista, IComparer<T> comparador, IObservadorOrdenamiento<T> observador = null);
    }
}
