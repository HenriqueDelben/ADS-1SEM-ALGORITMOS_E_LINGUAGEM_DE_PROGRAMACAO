/* 
OBJETIVO: Calcular o peso ideal de um usuário, seja masculino ou feminino
ENTRADA: Nome, altura, sexo (M/F)
SAÍDA: Peso ideal
*/

using System;
class Ex2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("CALCULADOR DE PESO IDEAL\n");
        
        while (true) // o while é um loop que leva como argumentos expressoes booleanas, é possivel dele fazer um teste de verdadeiro com um valor como em "while (i < 10)" - esta falando que o loop rodará enquanto a condição "i<10" não for quebrada e deixá-lo infinito usando "true"
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine(); // O "Console.ReadLine" é um metodo de Captura de Input, onde lê string e retorna string

            Console.Write("\nDigite a sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite o seu sexo (M/F): ");
            char sexo = Convert.ToChar(Console.Read());
            Console.Write("\n------------------------------");

            if (sexo == 'M' || sexo == 'm')
            {
                double pesoideal = (72.7 * altura) - 58;
                Console.WriteLine("\nNome: {0}", nome);
                Console.WriteLine("Altura: {0}", altura);
                Console.WriteLine("Peso ideal: {0}\n", pesoideal);
            }        
            else
            {
                double pesoideal = (62.1 * altura) - 44.7;
                Console.WriteLine("\nNome: {0}", nome);
                Console.WriteLine("Altura: {0}", altura);
                Console.WriteLine("Peso ideal: {0}\n", pesoideal);
            }
        }
    }
}