/*Desarrollar un programa que pida dos fechas y las almacenes en variables datetime, para posteriormente determinar y mostrar por pantalla:*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n1.La cantidad de dias transcurridos en el año para cada fecha.\n");

            Console.Write("\nDigite su 1er fecha (YY/MM/DD): ");
            DateTime fecha1 = Convert.ToDateTime(Console.ReadLine());

            Console.Write("\nDigite su 2da fecha (YY/MM/DD): ");
            DateTime fecha2 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"\n1er fecha {fecha1.ToShortDateString()}");
            Console.WriteLine($"2da fecha {fecha2.ToShortDateString()}");

            Console.WriteLine("\n2. La cantidad de días de diferencia entre amabas fechas;\n");

            TimeSpan difechas = fecha2 - fecha1;

            Console.WriteLine(difechas.Days);

            Console.WriteLine("\n3. El día de la primera fecha (Cantidad numérica).\n");

            Console.WriteLine(fecha1.Day);

            Console.WriteLine("\n4. Mostrar el día de la semana de la segunda fecha.\n");

            Console.WriteLine(fecha2.DayOfWeek);

            Console.WriteLine("\n5. Sumar la cantidad de días de la primera fecha en la segunda.\n");

            Console.WriteLine($"{fecha2.Day + fecha1.Day}/{fecha2.Month}/{fecha2.Year}");

            Console.WriteLine("\n6. Sumar la cantidad de años de la segunda fecha en la primera.\n");
            Console.WriteLine($"{fecha1.Day}/{fecha1.Month}/{fecha2.Year + fecha1.Year}");
        }
    }
}
