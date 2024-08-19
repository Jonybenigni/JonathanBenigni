using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimerParcialPOO2024Tema1.Shared
{
    internal class Piramide_Cuadrado
    {
       public double lado {  get; set; }
       public int altura { get; set; }
       public double area { get; set; }
       private double apotema {  get; set; }

       public double areaBase { get; set; }
       public double areaLateral { get; set; }
       
       public double volumen { get; set; }

        public void FuncionApotema(double Apotema)
        {
            Apotema = Math.Sqrt(lado / 2) * 2 + altura * altura;
        }

        public Piramide_Cuadrado(double Lado , int Altura ,double Apotema)
        {
            lado = Lado;
            altura = Altura;
            apotema = Apotema;

            if (lado < 0) 
            {
                ArgumentException argumentException = new ArgumentException();
            }
            else if (altura < 0)
            {
                ArgumentException argumentException = new ArgumentException();
            }
            else
            {
                return;
            }

            area = areaBase + areaLateral;

            areaBase = lado * lado;

            areaLateral = 2 * lado * apotema;

            volumen = (((lado * lado) * altura) / 3);

           
        }
        
        public double GetArea() => area;

        public double GetVolumen() => volumen;

        public string MostrarDatos()
        {
            return $"{lado}-{altura}-{area}-{volumen}";
        }






        










    }
}
