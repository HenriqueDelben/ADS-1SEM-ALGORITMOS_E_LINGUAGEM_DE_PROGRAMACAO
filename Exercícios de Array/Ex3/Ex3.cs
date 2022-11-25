/*
OBJETIVO: Ler 10 numeros somente positivos e armazenar em um array, identificar o maior numero do array e seu indice
ENTRADA: 10 numeros
SAIDA: Maior numero do array e seu índice
*/
using System;
using System.Linq;
class Ex3
{
    public static void Main(string []args)
    {
        double[] numeros = new double[10];
        bool teste = false;
        int posicao = 0;
        
        Console.WriteLine("Digite 10 numeros positivos: ");
        for (int i = 0; i < 10; i++)
        {
            while (teste == false)
            {   
                try
                {
                    numeros[i] = Convert.ToDouble(Console.ReadLine());
                    if (numeros[i] < 0)
                    {
                        Console.WriteLine("Valor negativo. Digite novamente:");
                        while (numeros[i] < 0)
                        {
                            numeros [i] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("\nValor invalido. Tente novamente");
                }
            }   
        }
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] == numeros.Max())
            {
                posicao = i;
            }
        }
        Console.Write("O maior numero presente na array e: {0}\nO numero {1} ocupa a posicao: {2}", numeros.Max(), numeros.Max(), posicao);
    }
}
    
