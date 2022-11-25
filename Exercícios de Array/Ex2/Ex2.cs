/*
OBJETIVO: Calcular a media de 10 valores e dizer quantos dos valores possui um valor acima da media calculada
ENTRADA: 10 numeros
SAIDA: Media e contagem dos valores acima da media
*/
using System;
class Ex2
{
    public static void Main(string []args)
    {
        double[] notas = new double[10];
        bool teste = false;
        int contador = 0;
        
        Console.WriteLine("Digite as 10 notas de cada aluno: ");
        
        for (int i = 0; i < 10; i++)
        {
            while (teste == false)
            {   
                try
                {
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Erro");
                }
            }   
        }
        foreach (var nota in notas)
        {
            if (nota > notas.Average())
            {
                contador += 1;
            }
        }
        Console.WriteLine("A media das notas dos alunos e: {0}\nO numero de alunos com nota acima da media e: {1}", notas.Average(), contador);
    }

}