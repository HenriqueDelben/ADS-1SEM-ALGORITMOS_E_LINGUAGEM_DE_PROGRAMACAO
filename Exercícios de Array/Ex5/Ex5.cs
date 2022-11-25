/*
OBJETIVO: Escrever um programa com a Linguagem C# para Ler um array A de 10 números.
Em seguida, ler mais um número e armazená-lo em uma variável X. Armazenar em
um array M o resultado de cada elemento de A multiplicado pelo valor X. Logo após,
exibir na console todos os elementos do array M
ENTRADA: 10 numeros na array A, valor X
SAIDA: Array M do produto de cada elemento de A e X
*/
using System;
class Ex5
{
    public static void Main(string []args)
    {
        double[] a = new double[10];
        double[] m = new double[10];
        double x = 0;
        bool teste = false;
        Console.WriteLine("Digite 10 numeros para o array A:");
        for (int i = 0; i < 10; i++)
        {
           while (teste == false)
            {   
                try
                {
                    a[i] = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\nValor invalido. Tente novamente");
                }
            }   
        }
        Console.WriteLine("Os valores digitados foram: [{0}]", string.Join(", ", a));
        Console.WriteLine("\nDigite mais um outro numero:");
        x = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            m[i] = a[i] * x;
        }
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Os elementos do array M sao: [{0}]", string.Join(", ", m));
    }
}