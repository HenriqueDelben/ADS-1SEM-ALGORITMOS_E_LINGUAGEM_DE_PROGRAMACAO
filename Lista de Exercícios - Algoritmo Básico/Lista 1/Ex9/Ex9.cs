/*
OBJETIVO: Ler dois valores e dizer qual é o maior
ENTRADA: 2 valores
SAIDA: 1 valor
*/
using System;
class Ex9
{
    public static void Main(string []args)
    {
        double [] numeros = new double [2];
        Console.WriteLine("Digite 2 valores: ");
        for (int i = 0; i < 2; i++)
        {
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("O {0} e o maior numero", numeros.Max());
    }
}