using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_1_Tarea1
{
       class Empleado
    {
        private int Sueldo;
        private string Nombre;
      
        public void Inicializar()
        {
            Console.WriteLine("Nombre Empleado");
            Nombre = Console.ReadLine();
            Console.WriteLine("Sueldo ");
            Sueldo = Convert.ToInt32(Console.ReadLine());
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Sueldo : "+Sueldo);
        }
        public void Impuestos()
        {
            if (Sueldo > 30000)
            {
                Console.WriteLine("Tiene que pagar impuestos");
            }
            else
            {
                Console.WriteLine("No puede pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado Nemp = new Empleado();
            Nemp.Inicializar();
            Nemp.ImprimirDatos();
            Nemp.Impuestos();
            Console.ReadKey();
        }
    }
}
