using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_2_Tarea1
{
    class Coordenada
    {
        private int x, y;

        public void Cargar()
        {
            Console.WriteLine("valor  X ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("valor  Y");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void Imprimir()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("esta representa un punto en el primer cuadrante");
                                 }
                              else if (x > 0 && y < 0)
                             {
                                 Console.WriteLine("esta representa un punto en el segundo cuadrante");
                             }
                                else if (x < 0 && y < 0)
                                {
                                Console.WriteLine("esta representa un punto en el tercer cuadrante");
                                }
                               else if (x < 0 && y > 0)
                                {
                                Console.WriteLine("esta representa un punto en el cuarto cuadrante");
                               }
                                     }
                               static void Main(string[] args)
                           {
                                 Coordenada nCoord = new Coordenada();
                              nCoord.Cargar();
                              nCoord.Imprimir();
                                Console.ReadKey();
        }
    }
}
