/*
OBJETIVO: Criar método que lê 3 valores e retorna o menor número
ENTRADA: 3 valores
SAIDA: 1 valor
*/
using System;
class Ex2
{
    public static void Main(string []args)
    {
        double [] numeros = new double [3];
        Ex2 valores = new Ex2();
        double menor;

        for (int i = 0; i < 3; i++)
        {
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }
       
       menor = valores.Menor(numeros);
       Console.WriteLine("O menor numero e: {0}", menor); 
    }
     double Menor(double[] numeros)
    {
        return numeros.Min();
    }
}