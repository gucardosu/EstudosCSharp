using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Fundamentos_C_.Logica.While
{
    internal class While1
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0){
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero negativo!");
        }
    }
}
