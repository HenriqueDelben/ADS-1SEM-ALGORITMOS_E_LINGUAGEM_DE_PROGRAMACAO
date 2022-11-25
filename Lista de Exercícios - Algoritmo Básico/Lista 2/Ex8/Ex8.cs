/*
OBJETIVO: Obter 15 valores e armazena-los em um vetor, calculando a media destes valores
ENTRADA: 15 numeros
SAIDA: Media dos 15 numeros
*/

Console.WriteLine("------------------------------\nCALCULADOR DE MEDIA\nDigite a nota de prova de 15 alunos: ");
double[] notas = new double [15];
for (int i = 0; i < 15; i++)
{
    notas[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"\nA media geral da nota destes 15 alunos e: {notas.Average()}");
Console.WriteLine("---------------------------");
Console.ReadKey();