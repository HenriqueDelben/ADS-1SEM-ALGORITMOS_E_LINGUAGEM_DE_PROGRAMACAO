/*
OBJETIVO: Ler nome, 3 notas, e informar sua media aritmética
ENTRADA: 4 valores (nome e 3 notas)
SAIDA: 2 valores (nome e media aritmetica)
*/
using System;
class Ex12
{
    public static void Main(string[] args)
    {
        string nome = "";
        double [] numeros = new double [3];
        Console.WriteLine("Digite o nome do aluno: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite as tres notas do aluno:");
        for (int i = 0; i < 3; i++)
        {
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("-----------------------");
        Console.WriteLine("NOME: {0}\nMEDIA: {1}", nome, numeros.Average());
        Console.ReadKey();
    }
}