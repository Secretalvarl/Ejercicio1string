using Ejercicio1string.Servicios;
using System.Security;
using System.Timers;

namespace Ejercicio1string.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OperativaInterfaz alpha = new OperativaImplementacion();

            int valor;
            string nombre;
            string apellido1;
            string apellido2;
            string nombreCompleto;
            int numerosDNI = alpha.pedidaNumerosDNI();
            string letraDNI = alpha.pedidaLetraDNI();
            string DNI = numerosDNI + letraDNI;
            int codigoPostal = alpha.pedirCodigoPostal();


            do
            {
                nombre = alpha.pedidaNombre();
                apellido1 = alpha.pedidaApellido1();
                apellido2 = alpha.pedidaApellido2();
                nombreCompleto = apellido1 + " " + apellido2 + ", " + nombre + ".";
                valor = alpha.verificarNombre(nombre, apellido1, apellido2, nombreCompleto);
            } while (valor == 1);


            string[] posicionLetraDNI = { "T", "R","W" , "A", "G","M", "Y", "F", "P", "D", "X", "P",
                "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            
            int numeroDividido = numerosDNI % 23;

            if (posicionLetraDNI[numeroDividido] == letraDNI)
            {
                Console.WriteLine("El DNI es valido: " + DNI);
            }else
            {
                Console.WriteLine("El DNI no es valido, vuelva a escribirlo");
            }


            int[] codigoPostales = { 41001, 41002, 41003, 41004, 41005, 41006, 41007, 41008, 41009, 41010,
                41011, 41012, 41013, 41014, 41015, 41016, 41017, 41018, 41019, 41020, 41092};

            for (int i = 0; i < codigoPostales.Length; i++)
            {
                if (codigoPostal == codigoPostales[i])
                {
                    Console.WriteLine("El codigo postal es de Sevilla: " + codigoPostal);
                }
            }
            



            string[] separar = nombreCompleto.Split(",");

            string apellidosJuntos = separar[0];


            nombreCompleto.Count();




        }
    }
}