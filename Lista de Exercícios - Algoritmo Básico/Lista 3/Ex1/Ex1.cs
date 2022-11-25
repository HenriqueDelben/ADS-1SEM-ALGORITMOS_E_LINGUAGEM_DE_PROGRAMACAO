/*
OBJETIVO: Ler um vetor de 10 valores e dizer quais sao os valores iguais caso existam
ENTRADA: 10 valores
SAIDA: Os valores iguais
*/
using System;
class Ex1
{
    public static void Main(string []args)
    {
        double [] numeros = new double [10];
        double [] numeros2 = new double [10];
        Console.WriteLine("Digite 10 valores:");

        for (int i = 0; i < 10; i++)
        {
            try
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                numeros2[i] = numeros[i];
            }
            catch
            {
                Console.WriteLine("\nValor digitado invalido. Tente novamente");
            }
        }
        Console.WriteLine("-----------------------------\nOs numeros repetidos sao: ");
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] == numeros2[i])
            {
                Console.WriteLine("{0}", numeros[i]);
            }
        }
    }
}
