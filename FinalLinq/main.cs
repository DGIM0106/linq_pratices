using LinqClass;

namespace FinalLinq
{
    internal class main
    {
        static void Main(string[] args)
        {
            Empleado[] listaEmpleados = new Empleado[]
            {
                new Empleado("Juan","Sitemas",2050m),
                new Empleado("Matias", "Marketing", 1500.25m),
                new Empleado("Daniel", "TI", 3000.15m),
                new Empleado("Diana", "Contabilidad", 1500.18m),
                new Empleado("karla", "Marketing", 2500.25m),
            };

            var filtro = listaEmpleados.Where(n=>n.Sueldo>=1600m).OrderBy(n => n.Sueldo).Select(n=>n.Nombre);
            foreach(var i in filtro)
            {
                Console.WriteLine(i);
            }
        }
    }
}
