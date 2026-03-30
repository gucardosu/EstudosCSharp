using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentos_C_.Exercicios_iF_Else
{
    internal class ex2
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0) { 
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
        }
    }
}
