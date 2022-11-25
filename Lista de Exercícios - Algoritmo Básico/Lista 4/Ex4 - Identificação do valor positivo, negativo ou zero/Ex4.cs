/*
OBJETIVO: CONSEGUIR IDENTIFICAR EM UM VALOR SE ELE É POSITIVO, NEGATIVO OU ZERO
ENTRADA: UM VALOR/NUMERO
SAÍDA: RESULTADO COM A IDENTIFICAÇÃO DO NÚMERO
*/
using System;
class Ex4
{
    static void Main (string []args)
    {
        while (true)
        {
            Console.Write("--------------");
            Console.WriteLine("\nDigite um numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("{0} e positivo", num1);
            }
            if (num1 < 0)
            {
                Console.WriteLine("{0} e negativo", num1);
            }
            if (num1 == 0)
            {
                Console.WriteLine("{0} e igual a 0", num1);
            }
        }    
    }   
}