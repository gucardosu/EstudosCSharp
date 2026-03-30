using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentos_C_.Exercicios_iF_Else
{
    internal class ex1
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine("O numero é positivo! ");
            } else if (n1 < 0) {
                Console.WriteLine("O numero é negativo!");
            } else {
                Console.WriteLine("Insira um numero Válido");
            }
        }
    }
}
