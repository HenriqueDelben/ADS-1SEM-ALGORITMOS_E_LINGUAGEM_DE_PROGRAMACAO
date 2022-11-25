/*
OBJETIVO: Calcular para dois candidatos o numero de votos totais para cada candidato, votos totais brancos, votos totais nulos, votos totais lidos/recebidos e mostrar quem é o candidato vencedor
ENTRADA:
SAIDA:
*/
using System;
class Ex3
{
    public static void Main(string []args)
    {
        while (true)
        { 
            // opcoes, incrementador, exit, voto, voto1, voto2, voto_nulo, voto_branco, resposta_db  
            bool exit = false;
            int incrementador = 0;
            int voto = 0;
            int voto1 = 0;
            int voto2 = 0;
            int voto_branco = 0;
            int voto_nulo = 0;
            Console.WriteLine("\nCAMPANHA 2022\nSelecione o que voce deseja consultar:\n1) Urna de Votacao\n2) Banco de dados");
            int opcoes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            if (opcoes == 1)
            {
                ConsoleKeyInfo menu;
                Console.WriteLine("\nURNA DE VOTAÇÃO");
                while (exit == false)
                {
                    Console.WriteLine("\nSelecione o seu voto:\n1) Jair Bolsonaro;\n2) Luiz Inacio Lula da Silva;\n3) Branco;\n4) Nulo");
                    voto = Convert.ToInt32(Console.ReadLine());
                    while (voto != 1 & voto != 2 & voto != 3 & voto != 4)
                    {  
                        if (incrementador == 0)
                        {
                            Console.WriteLine("\nVoto Invalido. Digite Novamente:");
                        }
                        voto = Convert.ToInt32(Console.ReadLine());
                        incrementador += 1;
                    }
                    if (voto == 1)
                    {
                        voto1 += 1;
                    }
                    if (voto == 2)
                    {
                        voto2 += 1;
                    }
                    if (voto == 3)
                    {
                        voto_branco += 1;
                    }
                    if (voto == 4)
                    {
                        voto_nulo += 1;
                    }
                    Console.WriteLine("Aperte \"Enter\" para continuar ou \"Escape\" para retornar ao menu principal");
                    menu = Console.ReadKey();
                    if (menu.Key == ConsoleKey.Escape)
                    {
                        exit = true;
                    }
                    if (menu.Key == ConsoleKey.Enter)
                    {
                        exit = false;
                    }
                }
            }
            if (opcoes == 2)
            {
                ConsoleKeyInfo menu;
                Console.WriteLine("A) Total de votos para cada candidato;\nB) Total de votos brancos;\nC) Total de votos nulos;\nD) Total de votos lidos;\nE) Resultado");
                string resposta_db = Console.ReadLine();

                if (resposta_db == "A" || resposta_db == "a")
                {
                    Console.WriteLine(voto1 + voto2);
                }

                if (resposta_db == "B" || resposta_db == "b")
                {
                    Console.WriteLine(voto_branco);
                }
                
                if (resposta_db == "C" || resposta_db == "c")
                {
                    Console.WriteLine(voto_nulo);
                }
                
                if (resposta_db == "D" || resposta_db == "d")
                {
                    Console.WriteLine(voto1 + voto2 + voto_branco + voto_nulo);
                    
                }
                
                if (resposta_db == "E" || resposta_db == "E")
                {
                    if (voto1 > voto2)
                    {
                        Console.WriteLine("Jair Bolsonaro");
                    }
                    if (voto1 < voto2)
                    {
                        Console.WriteLine("Luiz Inacio Lula da Silva");
                    }
                }
                Console.WriteLine("Aperte \"Enter\" para continuar ou \"Escape\" para retornar ao menu principal");
                    menu = Console.ReadKey();
                    if (menu.Key == ConsoleKey.Escape)
                    {
                        exit = true;
                    }
                    if (menu.Key == ConsoleKey.Enter)
                    {
                        exit = false;
                    }
            }
        }
    }
}