/*
OBJETIVO: INFORMAR O NOME E MEDIA ARITMETICA DE UM ALUNO
ENTRADA: NOME, NOTA 1, NOTA 2 E NOTA 3 
SAIDA: NOME E MEDIA ARITMETICA
*/
using System;
class Ex4
{
    public static void Main(string []args)
    {
        double [] notas = new double[3];
        string nome;

        nome = Console.ReadLine();
        Console.WriteLine("Digite as notas do aluno:");
        for (int i = 0; i < 3; i++)
        {
            notas[i] = Convert.ToDouble(Console.ReadLine());
            if (notas[i]<0 || notas[i]>10)
            {
                do
                {
                    Console.WriteLine("\nErro, nota invalida. Digite novamente: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }
                while(notas[i]<0 || notas[i]>10);
            }
	    }
        Console.WriteLine("-----------------\nNOME: {0}\nNOTA: {1}", nome, notas.Average());       
    }
}