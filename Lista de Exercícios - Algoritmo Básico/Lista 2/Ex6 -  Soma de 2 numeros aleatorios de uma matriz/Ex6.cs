/* 
OBJETIVO: Preencher uma matriz de 8 numeros a partir da entrada do usuario e a partir de outros 2 valores X e Y, mostrar a soma dos valores da matriz nas posições X e Y
ENTRADA: 8 numeros para a matriz, 2 numeros inteiros para o indice
SAIDA: Soma dos valores correspondentes da matriz nas posições X e Y
*/
using System;
class Ex6
{
    public static void Main(string []args)
    {
        bool excecao = false;
        int[] matriz1 = new int[2];
        double[] matriz = new double[8];
        Console.WriteLine("Digite 8 numeros: ");

        for (int i = 0; i < 8; i++)
        {
            matriz[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("\nDigite agora outros 2 numeros inteiros entre 0 e 8: ");

        while (excecao == false)    
            try
            {
                matriz1[0] = Convert.ToInt32(Console.ReadLine());
                matriz1[1] = Convert.ToInt32(Console.ReadLine());
                excecao = true;
            }
            catch (Exception)
            {
                Console.WriteLine("\nValor nao inteiro. Digite novamente: ");
            }
        Console.WriteLine($"\nOs valores aleatorios do seu conjunto de 8 numeros sao: {matriz[matriz1[0]]} e {matriz[matriz1[1]]}");
        Console.WriteLine("A soma deles e: {0}\n\n", matriz[matriz1[0]] + matriz[matriz1[1]]);
    }
}