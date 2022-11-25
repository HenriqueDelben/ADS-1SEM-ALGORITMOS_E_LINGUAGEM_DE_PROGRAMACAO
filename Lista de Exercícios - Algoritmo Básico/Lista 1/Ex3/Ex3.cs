/*
OBJETIVO:  INFORMAR O NOME, SALARIO FIXO E O SALARIO NO FINAL DO MES DE UM VENDEDOR
ENTRADA: NOME, SALARIO FIXO E TOTAL DE VENDAS EM DINHEIRO REALIZADAS NO MES
SAIDA: NOME, SALARIO FIXO E SALARIO FINAL
*/
using System;
class Ex3
{
    public static void Main(string []args)
    {
        int salariofixo, numerodevendas, salariofinal;
        string nome = "";
        Console.WriteLine("BANCO DE DADOS LOJAMULTIMARCAS\nVERSAO 1.0\nCARREGANDO DADOS...");
	    Console.WriteLine("\nOla!\n\nDigite o nome do vendedor: ");
	    nome = Console.ReadLine();
	    Console.WriteLine("Digite agora o salario fixo deste vendedor: ");
	    salariofixo = Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine("Por ultimo, digite o total de vendas realizadas por este vendedor (em dinheiro): ");
	    numerodevendas = Convert.ToInt32(Console.ReadLine());

	salariofinal = numerodevendas * 20 / 100 + salariofixo;
	Console.WriteLine("\nNOME: {0}\nSALARIO FIXO: {1}\nSALARIO NO FINAL DO MES: {2}\n\n", nome, salariofixo, salariofinal);


    }
}