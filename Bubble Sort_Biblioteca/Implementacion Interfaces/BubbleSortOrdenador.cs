using Bubble_Sort_Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Biblioteca.Implementacion_Interfaces
{
    public class BubbleSortOrdenador <T> : Iordenador<T>
    {
        public void Ordenar(List<T> lista, IComparer<T> comparador, IObservadorOrdenamiento<T> observador = null)
        {
            int n = lista.Count;
            observador?.AlIniciar(lista);

            for (int i = 0; i < n - 1; i++)
            {
                bool intercambiado = false;
                observador?.AlIniciarPasada(i + 1);

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparador.Compare(lista[j], lista[j + 1]) > 0)
                    {
                        (lista[j], lista[j + 1]) = (lista[j + 1], lista[j]);
                        intercambiado = true;
                        observador?.AlIntercambiar(lista[j], lista[j + 1]);
                    }
                }

                observador?.AlFinalizarPasada(lista, n - i - 1);

                if (!intercambiado)
                {
                    observador?.AlDetectarListaOrdenada();
                    break;
                }
            }

            observador?.AlFinalizar(lista);
        }
    }
}
