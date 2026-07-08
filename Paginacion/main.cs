using LinqClass;

namespace Paginacion
{
    internal class main
    {
        static void Main(string[] args)
        {
            Empleado[] arrayempleados = new Empleado[]
            {
                new Empleado("Juan","Sitemas",2050m),
                new Empleado("Matias", "Marketing", 1500.25m),
                new Empleado("Daniel", "TI", 3000.15m),
                new Empleado("Diana", "Contabilidad", 1500.18m),
                new Empleado("karla", "Marketing", 2500.25m),
            };

            var lista = arrayempleados.Select(d => d.Departamento).Distinct().OrderBy(d=>d);
            foreach(var i in lista)
            {
                Console.WriteLine(i);
            }
        }
    }
}
