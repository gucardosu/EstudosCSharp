using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentos_C_.Logica.For
{
    internal class ex1For
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número: e veja a tabuada dele ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
