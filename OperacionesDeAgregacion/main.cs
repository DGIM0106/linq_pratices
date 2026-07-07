using LinqClass;
using System.Linq;

namespace OperacionesDeAgregacion
{
    internal class main
    {
        static void Main(string[] args)
        {
            Empleado[] listaEmpleado = new Empleado[]
            {
                new Empleado("Juan","Sitemas",2050m),
                new Empleado("Matias", "Marketing", 1500.25m),
                new Empleado("Daniel", "TI", 3000.15m),
                new Empleado("Diana", "Contabilidad", 1500.18m),
                new Empleado("karla", "Marketing", 2500.25m),
            };
            //suma unciamente de la propiedad sueldo de cada empleado
            var sumaNomina = listaEmpleado.Sum(e => e.Sueldo);
            Console.WriteLine(sumaNomina);

            //promedio de la propiedad sueldo por area especifica
            var filtromarketing = listaEmpleado.Where(n => n.Departamento == "Marketing").Average(n => n.Sueldo);
            Console.WriteLine(filtromarketing);

            //agrupar por grupo
            var agrupacion = listaEmpleado.GroupBy(e => e.Departamento);
            foreach(var i in agrupacion)
            {
                foreach(var o in i)
                {
                    Console.WriteLine(o.Nombre + " " +o.Departamento);
                }
                Console.WriteLine("********");
            }
        }
    }
}
