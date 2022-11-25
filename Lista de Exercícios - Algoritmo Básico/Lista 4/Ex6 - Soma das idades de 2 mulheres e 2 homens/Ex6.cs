/*
OBJETIVO: Ler 4 idades (2 homens e 2 mulheres) e fazer duas somas de maior com menor de cada gênero
ENTRADA: 4 idades
SAIDA: 2 somas
*/
using System;
class Ex6
{
    public static void Main(string []args)
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int incrementador = 0;
        Console.WriteLine("-------------------");
        Console.WriteLine("Digite 4 valores para idades de 2 homens e 2 mulheres respectivamente");
        Console.Write("1 - ");
        do
        {
            if (incrementador >= 1)
                Console.WriteLine("\nNumero menor que 0. Digite uma idade válida: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            incrementador++;
        }
        while (num1 <= 0 || num1 > 110);
        
        Console.Write("\n2 - ");
        do
        {
            incrementador = 0;
            if (incrementador >= 1)
                Console.WriteLine("\nNumero menor que 0. Digite uma idade válida: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            incrementador++;
        }
        while (num2 <= 0 || num1 > 110);

        Console.Write("\n3 - ");
        do
        {
            incrementador = 0;
            if (incrementador >= 1)
                Console.WriteLine("\nNumero menor que 0. Digite uma idade válida: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            incrementador++;
        }
        while (num2 <= 0 || num1 > 110);

        Console.Write("\n4 - ");
        do
        {
            incrementador = 0;
            if (incrementador >= 1)
                Console.WriteLine("\nNumero menor que 0. Digite uma idade válida: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            incrementador++;
        }
        while (num2 <= 0 || num1 > 110);

        int soma1 = Math.Max(num1, num2) + Math.Min(num3, num4);

        int soma2 = Math.Min(num1, num2) + Math.Max(num3, num4);

        Console.WriteLine("A soma das idades do homem mais velho com a mais nova e: " + soma1);
        Console.WriteLine("A soma das idades do homem mais novo com a mais velha e: " + soma2);
    }
}