/*
OBJETIVO: Informe qual a categoria do jogador com base em sua idade: 0-13 anos (INFANTIL), 13-17 (JUVENIL), 17+ (SENIOR)
ENTRADA: 1 valor
SAIDA: Infatil, juvenil ou senior
*/
using System;
class Ex8
{
    public static void Main(string []args)
    {
        int idade = 0;
        bool validade = false;
        Console.WriteLine("Digite qual a idade: ");
        while (validade == false)
        {
            try
            {
                idade = Convert.ToInt32(Console.ReadLine());  
                while (idade < 0 | idade > 1)
                {
                    Console.WriteLine("\nIdade invalida. Tente novamente: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    break;
                }  
                break;
            }
            catch
            {
                Console.WriteLine("\nValor invalido. Digite novamente");
            }
        }
        if (idade < 13)
        {
            Console.WriteLine("INFANTIL");
        }
        else if (idade > 13 & idade < 17)
        {
            Console.WriteLine("JUVENIL");
        }
        else
        {
            Console.WriteLine("SENIOR");
        }
    }
}