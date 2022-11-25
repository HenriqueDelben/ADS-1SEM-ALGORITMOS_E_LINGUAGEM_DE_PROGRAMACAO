/*
OBJETIVO: Ler um vetor de 10 posições e atribuir 0 para todos os numeros com valores negativos
ENTRADA: 10 valores
SAIDA: 10 valores
*/
using System;
class Ex2
{
    public static void Main(string []args)
    {
        double [] numeros = new double [10];
        bool testador = false;
        Console.WriteLine("Digite 10 valores:");

        for (int i = 0; i < 10; i++)
        {
            while (testador == false)
            {     
                try
                {
                    numeros[i] = Convert.ToDouble(Console.ReadLine());
                    if (numeros[i] < 0)
                    {
                        numeros[i] = 0;
                    }
                    testador = true;
                }
                catch
                {
                    Console.WriteLine("\nValor digitado invalido. Tente novamente");
                }
            }
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine("[{0}]\n", string.Join(", ", numeros));
    }
}