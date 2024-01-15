using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public int verificarNumero(int numerosDNI, string letraDNI, string DNI)
        {
            int valor;

            string[] posicionLetraDNI = { "T", "R","W" , "A", "G","M", "Y", "F", "P", "D", "X", "P",
                "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            int numeroDividido = numerosDNI % 23;

            if (posicionLetraDNI[numeroDividido] == letraDNI)
            {
                Console.WriteLine("El DNI es valido: " + DNI);

                valor = 0;
            }
            else
            {
                Console.WriteLine("El DNI no es valido, vuelva a escribirlo");

                valor = 1;
            }
            return valor;
        }
        public int pedirCodigoPostal()
        {
            Console.WriteLine("Escriba su codigo postal: ");
            int codigoPostal = Convert.ToInt32(Console.ReadLine());

            return codigoPostal;
        }

        public int verificarCodigoPostal(int codigoPostal, int valor)
        {

            int[] codigoPostales = { 41001, 41002, 41003, 41004, 41005, 41006, 41007, 41008, 41009, 41010,
                41011, 41012, 41013, 41014, 41015, 41016, 41017, 41018, 41019, 41020, 41092};

            for (int i = 0; i < codigoPostales.Length; i++)
            {
                if (codigoPostal == codigoPostales[i])
                {
                    Console.WriteLine("El codigo postal es de Sevilla: " + codigoPostal);

                    valor = 0;

                }
            }

            return valor;
        }
    }
}
