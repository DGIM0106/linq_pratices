using System;
using System.Collections.Generic;
using System.Text;

namespace LinqClass
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public decimal Sueldo { get; set; }
        
        public Empleado(string Nombre, string Departamento, decimal Sueldo)
        {
            this.Nombre = Nombre;
            this.Departamento = Departamento;
            this.Sueldo = Sueldo;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Empleado: {Nombre} | Depto: {Departamento} | Sueldo: ${Sueldo}");
        }

    }
}
