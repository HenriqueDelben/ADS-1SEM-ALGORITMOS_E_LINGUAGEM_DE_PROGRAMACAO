/*
OBJETIVO: Calcular a media de a partir da qntd maxima e minima de um estoque de um produto
ENTRADA: Quantidade atual, máxima e mínima do estoque 
SAÍDA: Quantidade média do estoque daquele produto
*/

using System;
class Ex1 
{
    public static void Main (string []args)
    {

        while (true)
        {
            string produto;
            int qatual = 0;
            int qmax = 0;
            int qmin = 0;
            int qmed = 0;

            Console.WriteLine("\nProduto: ");
            produto = Console.ReadLine(); //erro na hora de atribuir a string a input do usuario

            Console.WriteLine("\nQuantidade atual:");
            qatual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQuantidade maxima em estoque:");
            qmax = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQuantidade minima em estoque:");
            qmin = Convert.ToInt32(Console.ReadLine());

            qmed = (qmax + qmin) / 2;

            // imprimindo na tela
            Console.WriteLine("\nQuantidade media em estoque de {0}: {1}", produto, qmed);
            Console.Write("\n----------------------------\n");
        }
    }
}