/*
OBJETIVO: Calcular o quadrado dos componentes de um vetor
ENTRADA:
SAIDA:
*/
using System;
class Ex5
{
    public static void Main(string []args)
    {
        string resposta = "";
        bool excecao = false;
        int x = 0;
        do
        {
            excecao = false;  

            Console.WriteLine("\nDigite a quantidade de numeros desejada: ");
            while (excecao == false)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    excecao = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor não inteiro. Digite novamente:");
                }
            }
            while (x == 0)
            {
                Console.WriteLine("Valor invalido. Tente novamente: ");
            }
            double[] numeros = new double[x];
            double[] quadrados = new double[x];
            if (x == 1)
            {
                Console.WriteLine("Digite {0} numero: ", x);
            }
            if (x > 1)
            {
                Console.WriteLine("Digite {0} numeros: ", x);
            }

            for (int i = 0; i < x; i++)
            {
                try
                {
                    numeros[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("");
                }
                quadrados[i] = numeros[i] * numeros[i];   
            }
            Console.Write("\nOs numeros digitados foram: ");
            Console.WriteLine("[{0}]", string.Join(", ", numeros));
            Console.Write("O quadrado desses numeros foram: ");
            Console.WriteLine("[{0}]", string.Join(", ", quadrados));

            Console.WriteLine("\n\nDeseja começar novamente? S/N");
            resposta = Console.ReadLine();
        }
        while (resposta == "S" || resposta == "s");
    }   
}
  