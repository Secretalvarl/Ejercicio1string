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
            int numerosDNI;
            string letraDNI;
            string DNI;
            int codigoPostal;


            do
            {
                nombre = alpha.pedidaNombre();
                apellido1 = alpha.pedidaApellido1();
                apellido2 = alpha.pedidaApellido2();
                nombreCompleto = apellido1 + " " + apellido2 + ", " + nombre + ".";
                valor = alpha.verificarNombre(nombre, apellido1, apellido2, nombreCompleto);

            } while (valor == 1);


            do
            {
                numerosDNI = alpha.pedidaNumerosDNI();
                letraDNI = alpha.pedidaLetraDNI();
                DNI = numerosDNI + letraDNI;
                valor = alpha.verificarNumero(numerosDNI, letraDNI, DNI);

            } while (valor == 1);

            do
            {
                codigoPostal = alpha.pedirCodigoPostal();
                valor = alpha.verificarCodigoPostal(codigoPostal, valor);

            }while(valor == 1);

            
            string[] separar = nombreCompleto.Split(",");

            string apellidosJuntos = separar[0];


            int tamaño = nombreCompleto.Length;

            Console.WriteLine(tamaño);


            char decimoCaracter = nombreCompleto[9];

            Console.WriteLine(decimoCaracter);


            int buscarA = nombreCompleto.IndexOf('a');

            if (buscarA != -1)
            {
                Console.WriteLine("La primera a se encuentra en la posicion: " + buscarA);
            }
            else
            {
                Console.WriteLine("No hay ninguna a");
            }



            int buscarR = nombreCompleto.IndexOf('r', 3);

            if (buscarR != -1)
            {
                Console.WriteLine("La primera r se encuentra en la posicion: " + buscarR);
            }
            else
            {
                Console.WriteLine("No hay ninguna r");
            }



            char[] dividir = new char[nombre.Length];

            for (int i = 0; i < nombre.Length; i++)
            {
                dividir[i] = nombre[i];
            }

            Console.WriteLine("La variable nombre separada por letras:");
            foreach (char letra in dividir)
            {
                Console.Write(letra + " ");
            }


            int posicionARC = nombreCompleto.IndexOf("arc");

            if (posicionARC != -1)
            {
                Console.WriteLine("arc esta en la posicion: " + posicionARC);
            }
            else
            {
                Console.WriteLine("No hay arc en el nombre completo");
            }
        }
    }
}