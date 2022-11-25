/*
OBJETIVO: Ler dois valores e dizer se são iguais e caso sejam diferentes, informar qual é o maior
ENTRADA: 2 valores
SAIDA: "Iguais" / Maior numero
*/
using System;
class Ex5
{
    public static void Main(string []args)
    {
        double [] valores = new double[2];
        Console.WriteLine("Digite dois numeros:");
        for (int i = 0; i < 2; i++)
        {
            valores[i] = Convert.ToDouble(Console.ReadLine());
        }
        if (valores[0].Equals(valores[1]))
        {
            Console.WriteLine("Os valores digitados foram: {0}\nOs valores sao iguais", string.Join(", ", valores));
        }
        else
        {
            Console.WriteLine("Os numeros digitados foram: {0}\n{1} e o maior", string.Join(", ", valores), valores.Max());
        }
    }
}