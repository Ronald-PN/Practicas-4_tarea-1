using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_3_Tarea1
{
    class Socio
    {
        private int Antiguedad;
        private string Nombre;

        public Socio(string Nombre)
        {
            Console.WriteLine("Nombre de Socio ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Antiguedad en el Club; decirlo en años");
            Antiguedad = Convert.ToInt32(Console.ReadKey());

        }

        class Club
        {
            private Socio Socio_1, Socio_2, Socio_3;
            public Club()
            {
                Socio_1 = new Socio(Nombre);
                Socio_2 = new Socio();
                Socio_3 = new Socio();
            }
            public void MayorAntiguedad()
            {
                if (Socio_1.Antiguedad > Socio_2.Antiguedad && Socio_1.Antiguedad > Socio_3.Antiguedad)
                {
                    Console.WriteLine("El socio 1 es el de mayor antiguedad ");
                }
                else if (Socio_2.Antiguedad > Socio_3.Antiguedad)
                {
                    Console.WriteLine("El socio 2 es el de mayor antiguedad ");
                }
                else
                {
                    Console.WriteLine("El socio 3 es el de mayor antiguedad ");
                }
            }

            static void Main(string[] args)
            {
                Club NuevoClub = new Club();
                NuevoClub.Club();
            }
        }

    }
    }