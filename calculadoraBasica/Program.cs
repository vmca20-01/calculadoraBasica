using System;

namespace calculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Opciones de Calculadora"+
                          "\n"+
                          "\n1.Suma"+
                          "\n"+
                          "\nDigite la opcioncion a ejecutar : ");


            Console.ReadLine();
        }

        public static double suma(double pNumb1,double pNumb2) {

            double sum = pNumb1 + pNumb2;

            return sum;
        }

        public static double resta(double pNumb1, double pNumb2)
        {

            double rest = pNumb1 - pNumb2;

            return rest;
        }
    }
}
