/*
OBJETIVO: Calcular o valor de folhas de acordo com o numero de folhas: qntd < 200 = 0,50 | qntd > 200 = 0,30
ENTRADA: 1 numero
SAIDA: 1 valor
*/
using System;
class Ex7
{
    public static void Main(string []args)
    {
        Console.Write("Digite quantas folhas deseja comprar: ");
        int qntd = Convert.ToInt32(Console.ReadLine());
        double valor = 0;
        if (qntd < 200)
        {
            valor = qntd * 0.50;
        }
        else 
        {
            valor = qntd * 0.30;
        }
        Console.WriteLine("\n-----------------------------");
        Console.WriteLine("TOTAL: {0}", valor);
    }
}