using System;

namespace Dias.semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Práctica C# 3" + "\n");

            string dia;

            
            Console.WriteLine("¿En qué día de la semana te encuentras? (Escribir sin acentos por favor)");
            dia = Console.ReadLine();
            
            dia=dia.ToLower();

            
            if (dia == "lunes")
            { Console.WriteLine("Te encuentras en el primer día de la semana que es Lunes"); }
            else if (dia == "martes")
            { Console.WriteLine("Te encuentras en el segundo día de la semana que es Martes"); }
            else if (dia == "miercoles")
            { Console.WriteLine("Te encuentras en el tercer día de la semana que es Miércoles"); }
            else if (dia == "jueves")
            { Console.WriteLine("Te encuentras en el cuarto día de la semana que es Jueves"); }
            else if (dia == "viernes")
            { Console.WriteLine("Te encuentras en el quinto día de la semana que es Viernes y el cuerpo lo sabe"); }
            else if (dia == "sabado")
            { Console.WriteLine("Te encuentras en el sexto día de la semana que es Sábado y se da buena la parranda"); }
            else if (dia == "domingo")
            { Console.WriteLine("Te encuentras en el séptimo día de la semana que es Domingo y mañana se trabaja :-("); }
            else
                Console.WriteLine("No ingresó un día válido");











        }
    }
}
