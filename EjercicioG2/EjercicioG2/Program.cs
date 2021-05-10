using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioG2
{
    class Program
    {
        static void Main(string[] args)
        {

            string seguir = null;

            while (seguir != "no")
            {
                Console.WriteLine("Ingrese su nombre: ");
                String nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese su sexo (Mujer = M y Hombre = H)");
                Char genero = Convert.ToChar(Console.ReadLine());

                switch (genero)
                {
                    case 'M':
                        Console.WriteLine("La Sra.{0}", nombre);
                        break;

                    case 'H':
                        Console.WriteLine("El Sr.{0}", nombre);
                        break;
                }

                Console.WriteLine("Desea Continuar (si / no )");
                seguir = Console.ReadLine();
            }
           
            Console.ReadKey();
        }
    }
}
