/*Escreva um programa em C# que solicite o nome do usuário e indique o dia em que ele
deve comparecer ao posto de vacinação, considerando a regra:
Dia da semana/ Letra inicial do primeiro nome
Segunda-feira – de A a C; Terça - feira – de D a G; Quarta - feira – de H a L;
Quinta - feira – M; Sexta - feira – de N a Q; Sábado – de R a S; Domingo – de T a Z.
*/
using System;
using System.Linq;

namespace N1___Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dia1 = { 'A', 'B', 'C' };
            char[] dia2 = { 'A', 'B', 'C' };
            char[] dia3 = { 'A', 'B', 'C' };
            char[] dia4 = { 'A', 'B', 'C' };
            char[] dia5 = { 'A', 'B', 'C' };
            char[] dia6 = { 'A', 'B', 'C' };
            char[] dia7 = { 'A', 'B', 'C' };

            string nome = Console.ReadLine();
            
                /* Não posso declarar um vetor e especificar o seu tamanho como em: int[5] nomematriz;

                Uma matriz pode ter somente elementos de mesmo valor (Ou criando uma array de um objeto que permite ter elementos de diferentes tipos de dados)
                Uma matriz possui tamanho na memoria fixa ou dinamica em C#
  
                Um vetor é declarado da seguinte maneira:
                (tipo de dado do vetor)[] (nome da matriz); - "[]" é o simbolo utilizado que identifica uma matriz


                Posso declarar uma matriz e nao inicializa-la (sem indicar seu numero de elementos e nem quais sao seus elementos de primeira) como em:  
                int[] nomematriz; 

                Posso declarar e inicializa-la especificando seu numero de elementos mas sem indicar quais sao os elementos: 
                int[] nomematriz = new int[5] - o "new int[5]" é usado para declarar a array com o tamanho fixo - repare que o new() declara uma array com alocação de memoria dinamica (Heap), feita em tempo de execução

                Posso declarar e inicializa-la especificando quais sao os elementos dela e portanto, o numero de elementos):

                int[] nomematriz = { 1, 2, 3, 4, 5 }; - desta maneira é alocado na memoria estatica (stack) - a alocação é feita antes da execução
                
                Posso chamar o elemento de uma array pelo nome dela e o numero do elemento:
                int[] nome = { 1, 2 }; - em uma string funciona da mesma maneira
                nome[0] - Apareceria na tela o "1"

                string.IndexOf
                string.Contains
                foreach
                string.Lenght
                char.ToUpper
                char.ToLower
                */
            if (nome[0] = dia1)
            {

            }

        }
    }
}
