using Bubble_Sort_Biblioteca.Entidades;
using Bubble_Sort_Biblioteca.Interfaces;
using System;
using System.Collections.Generic;

namespace Bubble_Sort_Biblioteca.Implementacion_Interfaces
{
    public class ObservadorLibros  : IObservadorOrdenamiento<Libro>
    {
        public void AlIniciar(List<Libro> lista)
        {
            Console.WriteLine("\n--- Iniciando Bubble Sort ---");
        }

        public void AlIniciarPasada(int numeroPasada)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n-> Pasada {numeroPasada}:");
            Console.ResetColor();
        }

        public void AlIntercambiar(Libro a, Libro b)
        {
            // Punto de extensión opcional: aquí se podría registrar cada
            // intercambio individual (por ejemplo, a un log detallado).
        }

        public void AlFinalizarPasada(List<Libro> lista, int indiceLimiteOrdenado)
        {
            for (int k = 0; k < lista.Count; k++)
            {
                if (k >= indiceLimiteOrdenado)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"  - {lista[k]} * (Ordenado)");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  - {lista[k]}");
                }
            }
        }

        public void AlDetectarListaOrdenada()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Nota: No se realizaron intercambios en esta pasada. ¡El catálogo ya está ordenado!");
            Console.ResetColor();
        }

        public void AlFinalizar(List<Libro> lista)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n==========================================================");
            Console.WriteLine("  Catálogo Final Ordenado Alfabéticamente");
            Console.WriteLine("==========================================================");
            Console.ResetColor();
            MostrarLibros(lista);
        }

        public void MostrarLibros(List<Libro> lista)
        {
            foreach (var libro in lista)
            {
                Console.WriteLine($"  - {libro}");
            }
        }
    }
}
