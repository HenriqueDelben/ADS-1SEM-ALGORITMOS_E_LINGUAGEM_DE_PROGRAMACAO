/*
OBJETIVO: MOSTRAR O RESULTADO DAS OPERAÇÕES ARITMETICAS
ENTRADA: VALOR DE 2 NUMEROS
SAIDA: RESULTADOS DA SOMA, SUBTRACAO, DIVISAO E MULTIPLICACAO DESSES 2 NUMEROS
*/
using System;
class Ex2
{
    public static void Main (string []args)
    {
        double a, b;
        Console.WriteLine("Digite o primeiro numero:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("------------------------------\nOs resultados sao:\nSOMA: {0}\nSUBTRACAO: {1}\nDIVISAO: {2}\nMULTIPLICACAO: {3}\nMODULO: {4}", a+b, a-b, a/b, a*b, a%b);
        Console.ReadKey();
    }
}