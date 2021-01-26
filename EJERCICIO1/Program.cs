using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Resultados del test de capacitación";
            Console.WriteLine("Bienvenido a la calculadora de resultados del test de capacitación. \nA continuación, rellene lo que se le solicite para obtener los resultados y el nivel alcanzado");
            // T: preguntas totales
            // C: preguntas contestadas
            // R: resultados de porcentaje 
            // A: Lector de datos (argumento para int) 
            Int32 T, C, R;
            String A;
            Console.WriteLine("\nDigite el número de preguntas totales:\n");
            A = Console.ReadLine();
            T=  Int32.Parse(A);
            Console.WriteLine("\nDigite el número de preguntas contsetadas:\n");
            A = Console.ReadLine();
            C = Int32.Parse(A);

            R = (C * 100) / T;

            if (R >= 90)
            {
                Console.WriteLine("\n¡Felicidades! \nEl nivel obtenido es el nivel máximo. \nHas obtenido el  " + R + "%");
            } 
            if (R>=75 && R<90)
            {
                Console.WriteLine("\n¡Felicidades! \nEl nivel obtenido es el nivel medio. \nHas obtenido el  " + R + "%");
            }
            if (R >= 50 && R<75)
            {
                Console.WriteLine("\n¡Felicidades! \nEl nivel obtenido es el nivel regular. \nHas obtenido el  " + R + "%");
            }
            else if (R <50)
            {
                Console.WriteLine("\n¡Más suerte a la próxima! \nTus resultados están fuera de nivel. \nHas obtenido el  " + R + "%");
            }
            Console.ReadKey();

        }
    }
}
