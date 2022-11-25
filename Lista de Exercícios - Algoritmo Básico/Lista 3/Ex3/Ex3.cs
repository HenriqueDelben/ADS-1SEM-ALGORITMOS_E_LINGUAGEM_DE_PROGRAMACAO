/*
OBJETIVO: Criar método para conversão de temperatura em Celcius p/ Fahreheint
ENTRADA: 1 valor (temperatura em Celsius)
SAIDA: 1 valor (temperatura em Fahreheint)
*/
using System;
class Ex2
{
    public static void Main(string[]args)
    {
        string resposta = "";

        do
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("CONVERSOR DE TEMPERATURA");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Digite uma temperatura:");
            double valor = Convert.ToDouble(Console.ReadLine());
            double temperatura = Temperatura(valor);
            Console.WriteLine("---------------------------\n{0}", temperatura);
            Console.WriteLine("Mais uma vez? (S/N)");
            resposta = Console.ReadLine();
            Console.ReadKey();
        }
        while (resposta == "S" || resposta == "s");
    }
    public static double Temperatura(double temperatura)
    {
        temperatura = (9 * temperatura + 160)/5;
        return temperatura;
    }
}