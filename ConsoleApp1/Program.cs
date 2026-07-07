using System.Linq;
using System.Security.Cryptography;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //filtara .Where()
            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = numeros.Where(n => n % 2 == 0);

            foreach (var i in numerosPares)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");
            //tranformar .Select()
            var numerosmult10 = numeros.Select(n => n*10);
            foreach (var i in numerosmult10)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");
            //encadenado
            var filtroymult10 = numeros.Where(n => n > 5).Select(n => n * 10);
            foreach(var i in filtroymult10)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");
            // ordenar con .Orderby() .OrderByDescending()
            var filtroymult10ordenado = numeros.Where(n => n > 5).Select(n => n * 10).OrderByDescending(n => n).ToList<int>();
            foreach(var i in filtroymult10ordenado)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");
        }
    }
}
