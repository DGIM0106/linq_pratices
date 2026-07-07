namespace LinqClass
{
    public class main
    {
        static void Main(string[] args)
        {
            /*var empleado1 = new Empleado("Juan","Sitemas",2000m);
            var empleado2 = new Empleado("Matias", "Marketing", 1500.25m);
            var empleado3 = new Empleado("Daniel", "TI", 2000.15m);
            var empleado4 = new Empleado("Diana", "Contabilidad", 1500.18m);*/

            //Empleado[] listaempleado = new Empleado[] {empleado1, empleado2, empleado3, empleado4 };
            Empleado[] listaEmpleado = new Empleado[]
            {
                new Empleado("Juan","Sitemas",2050m),
                new Empleado("Matias", "Marketing", 1500.25m),
                new Empleado("Daniel", "TI", 3000.15m),
                new Empleado("Diana", "Contabilidad", 1500.18m),
            };
            //Console.WriteLine(listaEmpleado.Length);

            /*foreach(var i in listaEmpleado)
            {
                i.MostrarInfo();
            };*/

            var filtro = listaEmpleado.Where(n => n.Departamento == "Sitemas").Select(n => n.Nombre);

            foreach(var i in filtro)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********");

            var filtro2 = listaEmpleado.OrderByDescending(o => o.Sueldo).FirstOrDefault();
            if (filtro2 != null)
            {
                filtro2.MostrarInfo();
            }
            
        }
    }
}
