using Bubble_Sort_Biblioteca.Entidades;
using Bubble_Sort_Biblioteca.Implementacion_Interfaces;
using Bubble_Sort_Biblioteca.Interfaces;
using System;

namespace Bubble_Sort_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            ICatalogoLibros catalogo = new CatalogoLibrosEnMemoria();
            Iordenador<Libro> ordenador = new BubbleSortOrdenador<Libro>();
            var comparadorPorTitulo = new ComparadorPorTitulo();
            var observador = new ObservadorLibros();

            var libros = catalogo.ObtenerTodos();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================");
            Console.WriteLine("  BIBLIOTECA - ORDENAR LIBROS POR TÍTULO (BUBBLE SORT)");
            Console.WriteLine("==========================================================");
            Console.ResetColor();

            Console.WriteLine("\n--- Catálogo Inicial (Desordenado) ---");
            observador.MostrarLibros(libros);

            ordenador.Ordenar(libros, comparadorPorTitulo, observador);
        }
    }
    
}
