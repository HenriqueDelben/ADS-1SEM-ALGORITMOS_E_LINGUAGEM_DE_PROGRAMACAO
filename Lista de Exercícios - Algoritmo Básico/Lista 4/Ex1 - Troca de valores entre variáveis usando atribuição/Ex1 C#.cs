/*
OBJETIVO: solicitar os valores de idade e ano de nascimento do usuário e armazenar nas variaveis "A" e "B" e realizar a troca dos valores entre as variavéis somente com atribuição entre elas
ENTRADA: A (idade) E B (ano de nascimento)
SAÍDA: VARIAVEL A E B COM VALORES TROCADOS
*/

using System;
class Ex1
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Digite a sua idade:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A = {a}");
        Console.WriteLine("\nDigite o seu ano de nascimento:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"B = {a}");

        a = b + a;
        b = a - b;
        a = a - b;

        Console.Write("------------\n");
        Console.WriteLine($"A = {a}\nB = {b}");
    }
}
