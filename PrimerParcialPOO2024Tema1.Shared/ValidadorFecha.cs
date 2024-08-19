using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialPOO2024Tema1.Shared
{
    static class ValidadorFecha
    {
        public static int dia { get; set; }
        public static int mes { get; set; }
        public static int anio { get; set; }


        public static void FechaValida(int dia, int mes, int anio)
        {
            if (dia <= 0) 
            {
                Console.WriteLine("Dia Incorrecto, Ingrese el Dia Nuevamente");
            }
            if (mes <= 0)
            {
                Console.WriteLine("Mes Incorrecto, Ingrese el Mes Nuevamente ");


            }
            if (anio <= 0)
            {
                Console.WriteLine("Añio Incorrecto, Ingrese el Año Nuevamente ");

            }

        }
        public static void AnioBisiesto ( int anio)
        {

            if ()

        }

    }
  

}
