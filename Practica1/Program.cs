using System.ComponentModel.DataAnnotations;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Origen de datos
            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 2. Tu consulta LINQ materializada
            var resultado = numeros
                .Where(n => n > 5)
                .Select(n => n * 10)
                .OrderByDescending(n => n)
                .ToList();

            // 3. Mostrar los resultados en la consola
            foreach (var num in resultado)
            {
                Console.WriteLine(num);
            }
        }
    }
}
