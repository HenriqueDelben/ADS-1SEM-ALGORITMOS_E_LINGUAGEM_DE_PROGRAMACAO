/*
OBJETIVO: Ler 2 valores onde caso seja inserido um valor 0, requisitando uma nova entrada do usuário utilizando o "while"
ENTRADA: 2 valores
SAÍDA: Resultado da divisão dos 2 valores
*/
using System;
class Ex7
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Digite o primeiro valor:");
        double num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        while (num2 == 0)
        {
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        double divisao = num1 / num2;

        Console.WriteLine($"Divisao de {num1} por {num2} = {divisao}");
    }
}