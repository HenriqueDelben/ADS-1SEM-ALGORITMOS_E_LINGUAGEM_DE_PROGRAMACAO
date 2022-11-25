/*
OBJETIVO: Ler um numero e dizer se esta ou nao no intervalo 200-300
ENTRADA: 1 numero
SAIDA: Informar se esta ou nao no intervalo
*/
using System;
class Ex6
{
    public static void Main(string []args)
    {
        Console.WriteLine("Digite um numero:");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 200 | num < 300)
        {
            Console.WriteLine($"{num} esta no intervalo entre 200 e 300");
        }
        else
        {
            Console.WriteLine($"{num} nao esta no intervalo entre 200 e 300");
        }
    }
}