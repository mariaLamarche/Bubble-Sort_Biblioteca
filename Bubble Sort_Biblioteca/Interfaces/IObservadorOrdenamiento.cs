using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Biblioteca.Interfaces
{
    public interface IObservadorOrdenamiento <T>
    {
        void AlIniciar(List<T> lista);
        void AlIniciarPasada(int numeroPasada);
        void AlIntercambiar(T a, T b);
        void AlFinalizarPasada(List<T> lista, int indiceLimiteOrdenado);
        void AlDetectarListaOrdenada();
        void AlFinalizar(List<T> lista);
    }
}
