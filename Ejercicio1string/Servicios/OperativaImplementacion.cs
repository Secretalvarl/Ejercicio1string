using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1string.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string pedidaNombre()
        {
            Console.WriteLine("Escriba su nombre: ");
            string nombre = Console.ReadLine();

            return nombre;
        }
        
        public string pedidaApellido1()
        {
            Console.WriteLine("Escriba su primer apellido");
            string apellido1 = Console.ReadLine();

            return apellido1;
        }

        public string pedidaApellido2()
        {
            Console.WriteLine("Escriba su segundo apellido");
            string apellido2 = Console.ReadLine();

            return apellido2;
        }

        public int verificarNombre(string nombre, string apellido1, string apellido2, string nombreCompleto)
        {
            int valor;

            if (nombre == apellido1)
            {
                Console.WriteLine("El nombre coincide con el primer apeliido, cambielo ");

                valor = 1;
            }
            else if (nombre == apellido2)
            {
                Console.WriteLine("El nombre coincide con el segundo apeliido, cambielo ");

                valor = 1;
            }
            else
            {
                Console.WriteLine("El nombre no coincide con ningun apellido: " + nombreCompleto);

                valor = 0;
            }

            return valor;
        }

        public int pedidaNumerosDNI()
        {
            Console.WriteLine("Escriba los numeros de su DNI: ");
            int numerosDNI = Convert.ToInt32(Console.ReadLine());

            return numerosDNI;
        }

        public string pedidaLetraDNI()
        {
            Console.WriteLine("Escriba la letra de su DNI en mayuscula: ");
            string letraDNI = Console.ReadLine();

            return letraDNI;
        }

        public int pedirCodigoPostal()
        {
            Console.WriteLine("Escriba su codigo postal: ");
            int codigoPostal = Convert.ToInt32(Console.ReadLine());

            return codigoPostal;
        }

        
    }
}
