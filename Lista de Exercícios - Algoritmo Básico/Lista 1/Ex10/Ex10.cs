/*
OBJETIVO: Calcular a media aritmetica de 3 numeros digitados pelo usuário 
ENTRADA: 3 números
SAIDA: Media aritmética
*/
using System;
class Ex10
{
    public static void Main (string []args)
    {
        double [] numeros = new double[3];
        Console.WriteLine("Digite 3 valores:");
        for (int i = 0; i < 3; i++)
        {
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("-------------------\nMEDIA ARITMETICA: {0}", numeros.Average());
    }
}