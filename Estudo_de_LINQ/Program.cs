using a_OperadoresDeRestricao.ExemplosDeLinq;
using System;

namespace Estudo_de_LINQ
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ExemplosDeLinqDeOperadoresDeRestricao1.Usando_ForeachComLista();
            ExemplosDeLinqDeOperadoresDeRestricao1.Usando_Linq1_Query();
            ExemplosDeLinqDeOperadoresDeRestricao1.Usando_Linq1_Lambda();

            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}