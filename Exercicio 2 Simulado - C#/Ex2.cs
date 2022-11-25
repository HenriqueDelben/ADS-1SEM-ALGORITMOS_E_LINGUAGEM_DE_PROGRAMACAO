using System;
class Mainclass {
    public static void Main (string[] args)
    {
        int valor = 0; 
        int soma = 0;
        int maior = 0;
        int menor = int.MaxValue;
        int contagem = 0;
        int quantidade;

        Console.Write("Digite a quantidade de valor a serem inseridos: ");
        quantidade = Convert.ToInt32(Console.ReadLine());

        for (contagem = 0; contagem < quantidade; contagem++)
        {
            valor = Convert.ToInt32(Console.ReadLine());
            soma = valor + soma;
            
            if (valor > maior)
            {
                maior = valor;
            }
            if (valor < menor)
            {
                menor = valor;
            } 
        }
        Console.WriteLine("A soma de todos os numeros digitados é: " + soma);
        Console.WriteLine("O maior valor digitado foi: " + maior);
        Console.WriteLine("O menor valor digitado foi: " + menor);  

    }
}