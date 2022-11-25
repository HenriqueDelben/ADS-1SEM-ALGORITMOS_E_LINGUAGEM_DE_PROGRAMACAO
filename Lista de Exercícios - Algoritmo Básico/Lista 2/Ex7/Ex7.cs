/*
OBJETIVO: Ler 6 valores inteiros e imprimi-los na ordem inversa
ENTRADA: 6 valores inteiros
SAIDA: 6 valores na ordem inversa
*/
using System;
class Ex7
{
    public static void Main(string[]args)
    {
        int[] numeros = new int[6];
        Console.WriteLine("Digite 6 valores inteiros: ");

        for (int i = 0; i < 6; i++)
        {
            try
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nTente novamente");
            }
        }
        Console.WriteLine("\nOs numeros invertidos sao: ");
        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}