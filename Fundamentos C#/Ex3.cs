using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentos_C_
{
    internal class Ex3
    {
        public static void Executar(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro: ");
            int num3 = int.Parse(Console.ReadLine());
            int soma = num1 + num2 + num3;
            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}
