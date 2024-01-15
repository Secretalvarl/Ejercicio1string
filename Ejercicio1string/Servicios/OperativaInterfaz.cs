using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1string.Servicios
{
    internal interface OperativaInterfaz
    {
        public string pedidaNombre();

        public string pedidaApellido1();

        public string pedidaApellido2();

        public int pedidaNumerosDNI();

        public string pedidaLetraDNI();

        public int pedirCodigoPostal();

        public int verificarNombre(string nombre, string apellido1, string apellido2, string nombreCompleto);

        public int verificarNumero(int numerosDNI, string letraDNI, string DNI);

        public int verificarCodigoPostal(int codigoPostal, int valor);
    }
}
