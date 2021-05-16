using System;
using System.Collections.Generic;
using System.Linq;

namespace a_OperadoresDeRestricao.ExemplosDeLinq
{
    public static class ExemplosDeLinqDeOperadoresDeRestricao1
    {
        private static readonly int[] Numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        // Linq de operadores de restrição(filtragem)
        // "where" - Valores filtrados baseado na condição
        // "OfType" - Valores filtrado beseados no tipo especificado

        // Imagine que tenha uma situação de filtragem que precisa que
        // Selecione todos os números menores que 5
        // Este exemplo usa a cláusula "where" para encontrar todos os elementos de um array com valor menor que 5

        // Forma de resolução usando Foreach com Lista
        public static void Usando_ForeachComLista()
        {
            var numerosFiltrados = new List<int>();

            foreach (var num in Numeros)
            {
                if (num < 5)
                {
                    numerosFiltrados.Add(num);
                }
            }
            Console.Write("Resultado com  Foreach e Lista: ");
            FiltrarNumeros(numerosFiltrados);
        }

        // Forma de resolução usando Linq com query
        public static void Usando_Linq1_Query()
        {
            var numerosFiltrados =
                from num in Numeros
                where num < 5
                select num;

            Console.Write("Resultado com sintaxe de Query: ");
            FiltrarNumeros(numerosFiltrados);
        }

        // Forma de resolução usando Linq com Lambda
        public static void Usando_Linq1_Lambda()
        {
            var numerosFiltados = Numeros.Where(num => num < 5);

            Console.Write("Resultado com expressão Lambda: ");
            FiltrarNumeros(numerosFiltados);
        }

        private static void FiltrarNumeros(IEnumerable<int> numerosFiltrados)
        {
            foreach (var numero in numerosFiltrados)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine();
        }
    }
}