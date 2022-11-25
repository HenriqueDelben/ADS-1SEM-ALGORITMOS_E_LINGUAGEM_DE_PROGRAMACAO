/*
OBJETIVO: Ler 2 numeros e imprimir 3 mensagens dependendo se eles são iguais ou diferentes
ENTRADA: 2 numeros
SAÍDA: Iguais, 1° Maior, 2° Maior
*/
using System;
class Ex5 
{
    public static void Main(string []args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.WriteLine("Digite 2 valores: ");
            Console.Write("1 - ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2 - ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Numeros iguais");
                Console.WriteLine("\n--------------");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Primeiro e maior");
                Console.WriteLine("--------------");
            }
            else
            {
                Console.WriteLine("Segundo e maior");
                Console.WriteLine("--------------");
            }
            Console.WriteLine("Pressione \"Enter\" para reiniciar ou \"Esc\" para finalizar o processo");
            tecla = Console.ReadKey();
            Console.WriteLine("--------------");

        }
        while (tecla.Key == ConsoleKey.Enter);



    }
}