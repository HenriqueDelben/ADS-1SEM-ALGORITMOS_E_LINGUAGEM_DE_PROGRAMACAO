using System;
class Ex2 {
    public static void Main (string[] args)
    {
        double p1, p2, p3, mediafinal;

        Console.Write("Digite a nota da primeira prova: ");
        p1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da segunda prova: ");
        p2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da terceira prova: ");
        p3 = Convert.ToDouble(Console.ReadLine());

        mediafinal = (p1 * 2 + p2 * 2 + p3 * 4) / 8;

        if (mediafinal >=6)
        {
            Console.Write("\n");
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.Write("\n");
            Console.WriteLine("Reprovado");
        }
        Console.ReadKey();
    }
}