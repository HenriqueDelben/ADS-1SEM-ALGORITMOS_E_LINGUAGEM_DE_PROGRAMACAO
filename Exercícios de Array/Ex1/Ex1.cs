/*
OBJETIVO: Captar 10 valores de entrada do usuário e colocar em uma array emais 1 valor especial, mostrando se o último valor existe dentro do array ou não
ENTRADA: 11 valores (10 em uma array e 1 separado)
SAIDA: "Valor X encontrado no array" ou "Valor não encontrado no array"
*/
using System;
class Ex1
{
    public static void Main(string []args)
    {
        int[] numeros = new int[10];
        bool teste = false;
        int x = 0;
        int i = 0;

        Console.WriteLine("Digite 10 numeros inteiros:");
        
        for (i = 0; i < 10; i++)
        {
            while (teste == false)
            {   
                try
                {
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Erro");
                }
            }   
        }
        Console.WriteLine("Elementos armazenados no array: {0}", string.Join(", ", numeros)); // string.Join (<separador>, <coleção>) -> utilizado para formatar os elementos de uma coleção
        
        Console.Write("\nDigite mais 1 numero: ");
        x = Convert.ToInt32(Console.ReadLine());
        
        if (numeros.Contains(x))
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nValor {0} encontrado no array", x);
        }
        else 
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nValor {0} nao encontrado no array", x);
        }
        Console.ReadKey();
    }
}