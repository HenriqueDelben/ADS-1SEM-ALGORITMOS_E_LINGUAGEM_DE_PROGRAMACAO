/*
OBJETIVO: Ler 10 numeros e exibi-los em ordem inversa de entrada armazenando em uma array
ENTRADA: 10 numeros
SAIDA: 10 numeros em ordem inversa de entrada
*/
using System;
class Ex6
{
    public static void Main(string[] args)
    {
        double[] numeros = new double[10];

        Console.WriteLine("Digite 10 numeros:");
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Os numeros digitados em ordem inversa foram: [{0}]", string.Join(", ", numeros.Reverse()));
    }
}