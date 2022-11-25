/*
OBJETIVO: Informar se um numero é par ou ímpar
ENTRADA: 1 numero
SAIDA: "Par" ou "Impar"
*/
using System;
class Ex11
{
    public static void Main(string []args)
    {
        Console.WriteLine("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num % 2 == 0)
        {
            
            Console.WriteLine($"-----------\n{num} e par");
        }
        if (num % 2 != 0)
        {
            Console.WriteLine($"----------\n{num} e impar");
        }
    }
}