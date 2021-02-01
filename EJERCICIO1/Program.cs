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
            // pregTotales: preguntas totales
            // contestadas: preguntas contestadas
            // Result: resultados de porcentaje 
            // A: Lector de datos (argumento para int) 
            Int32 pregTotales, contestadas, Result;
            String A;
            Console.WriteLine("\nDigite el número de preguntas totales:\n");
            A = Console.ReadLine();
            pregTotales=  Int32.Parse(A);
            Console.WriteLine("\nDigite el número de preguntas contsetadas:\n");
            A = Console.ReadLine();
            contestadas = Int32.Parse(A);

            Result = (contestadas * 100) / pregTotales;

            if (Result >= 90)
            {
                Console.WriteLine("\n¡Felicidades! \nEl nivel obtenido es el nivel máximo. \nHas obtenido el  " +Result + "%");
            } 
            if (Result>=75 && Result<90)
            {
                Console.WriteLine("\n¡Felicidades! \nEl nivel obtenido es el nivel medio. \nHas obtenido el  " + Result + "%");
            }
            if (Result>= 50 && Result<75)
            {
                Console.WriteLine("\n¡Felicidades! \nEl nivel obtenido es el nivel regular. \nHas obtenido el  " + Result + "%");
            }
            else if (Result <50)
            {
                Console.WriteLine("\n¡Más suerte a la próxima! \nTus resultados están fuera de nivel. \nHas obtenido el  " + Result + "%");
            }
            Console.ReadKey();

        }
    }
}
