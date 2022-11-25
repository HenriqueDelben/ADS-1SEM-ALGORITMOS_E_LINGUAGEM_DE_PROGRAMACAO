/*
OBJETIVO: Ler um vetor e retornar a soma dos valores impares
ENTRADA: Vetor de x tamanho
SAIDA: Soma dos elementos impares do vetor
*/
using System;
class Ex5
{
    public static int SomaImpar(int [] numeros, int tamanho)
    {
        int soma = 0;

        for (int i = 0; i < tamanho; i++)
        {
            if (numeros[i] % 2 == 1)
            {
                soma += numeros[i];
            }
        }
        return soma;
    }
    public static void Main(string []args)
    {
        int resposta = 0;
        Console.Write("Digite o numero desejado de elementos no vetor: ");
        resposta = Convert.ToInt32(Console.ReadLine());
        int [] numeros = new int [resposta];

        Console.WriteLine("\nDigite os valores:");

        for (int i = 0; i < resposta; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        int soma = SomaImpar(numeros, resposta);
        Console.WriteLine(soma);
        Console.WriteLine("---------------------------------");
    } 
}