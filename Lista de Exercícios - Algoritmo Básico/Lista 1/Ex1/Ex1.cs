/*
OBJETIVO: CALCULAR AREA DE UM TRIANGULO
ENTRADA: VALOR DA BASE E ALTURA
SAIDA: VALOR DA AREA DO TRIANGULO
*/
using System;
class Ex2
{
    public static void Main (string []args)
    {
        Console.WriteLine("Digite o valor da base:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura:");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("-----------------------");
        Console.WriteLine("O valor da area do triangulo e: {0}", (b + altura/2));
    }
}
