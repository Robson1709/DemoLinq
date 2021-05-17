using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("São Miguel");
            cidades.Add("São José");
            cidades.Add("Ribeirão Preto");

            BuscarPrimeiroComLinqLambda(cidades, "Sã").ForEach(x => Console.WriteLine(x));
            Console.ReadKey();

        }

        public static string BuscarPrimeiroComForeach(List<string> lista, string termo)
        {
            foreach(string item in lista)
            {
                if (item.Equals(termo)) return item;
            }
            return null;
        }

        public static List<string> BuscarPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public static List<string> BuscarPrimeiroComLinqLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
    }
}
