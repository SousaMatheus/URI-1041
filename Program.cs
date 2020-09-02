using System;
using System.Globalization;

namespace URI_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;

            string []vet = Console.ReadLine().Split(' ');
            valor1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
            valor2 = double.Parse(vet[1],CultureInfo.InvariantCulture);

            if (valor1 == 0.0 && valor2 == 0.0){
                Console.WriteLine("Origem");
            }
            else if (valor1 == 0.0 && valor2 > 0.0 || valor2 < 0.0){
                Console.WriteLine("Eixo X");                
            }
            else if (valor1 >0.0 || valor1 <0.0 && valor2 == 0.0){
                Console.WriteLine("Eixo Y");
            }

            else if (valor1 > 0.0 && valor2 > 0.0){
                Console.WriteLine("Q1");
            }
            else if (valor1 >0.0 && valor2 <0.0){
                Console.WriteLine("Q4");
            }
            else if ( valor1 < 0.0 && valor2 > 0.0){
                Console.WriteLine("Q2");
            }
            else {
                Console.WriteLine("Q3");
            }
            

        }
    }
}
