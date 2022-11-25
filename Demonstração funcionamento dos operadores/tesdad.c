/* Exemplos Operadores de Atribuição:
- Operadores Aritméticos
- Operadores Aritméticos Reduzidos
- Operadores Incrementais e Decrementais
- Operadores Lógicos
- Operadores Ternários
*/
#include <stdio.h>

int main()
{
    int i = 0, z = 0, x = 0;

    // DEMONSTRAR OPERADOR DE ATRIBUIÇÃO - '='
    printf("i = %d\nz = %d\nx = %d", i, z, x);




    // DEMONSTRAR OPERADORES ARITMETICOS  
    printf("\n------------------------");
    printf("\nPara valores onde x, z e i = 2");
    
    i = 2;
    z = 2;
    x = i + z;
    printf("\n i + z = %d", x); // soma -> +

    i = 2;
    z = 2;
    x = i - z;
    printf("\n i - z = %d", x); // subtração -> -

    i = 2;
    z = 2;
    x = i / z;
    printf("\n i / z = %d", x); // divisão -> /

    i = 2;
    z = 2;
    x = i * z;
    printf("\n i * z = %d", x); // multiplicação -> *

    i = 2;
    z = 2;
    x = i % z;
    printf("\n i %% z = %d", x); // modulo (resto divisao de x / z) -> %


    // DEMONSTRAR OPERADORES ARITMETICOS REDUZIDOS
    printf("\n------------------------");
    printf("\nPara onde x = 5");
    x = 5;
    x += 5;
    printf("\nValor de x += 5: %d", x); // mais igual -> +=
    
    x = 5;
    x -= 5;
    printf("\nValor de x -= 5: %d", x); // menos igual -> -=
    
    x = 5;
    x /= 5;
    printf("\nValor de x /= 5: %d", x); // divido igual -> /=
    
    x = 5;
    x *= 5;
    printf("\nValor de x *= 5: %d", x); // vezes igual -> *=
    
    x = 5;
    x %= 5;
    printf("\nValor de x %%= %d", x); // modulo igual -> %=

   
    // DEMONSTRAR OPERADORES INCREMENTAIS E DECREMENTAIS
    // pré-incremento (++)
    printf("\n------------------------");
    printf("\nPara onde a expressao e do tipo (++z/z++/--z/z--) + 20");
    x = 0;
    z = 0;
    x = ++z + 20; // faz o incremento antes de fazer a operação de soma "+20"
    printf("\nPre Incremento: ");
    printf("%d", x);
    
    // pós-incremento (++)
    x = 0;
    z = 0;
    x = z++ + 20; // faz o incremento em uma proxima instruçao
    printf("\nPos Incremento: ");
    printf("%d", x);

    // pre decremento (--)
    x = 0;
    z = 0;
    x = --z + 20; // faz o decremento antes de fazer a operação de soma "+20"
    printf("\nPre Decremento: ");
    printf("%d", x);

    // pos decremento (--)
    x= 0;
    z = 0;
    x = z-- + 20; 
    printf("\nPos Decremento: "); // faz o decremento em uma proxima instrução
    printf("%d", x);

    //OPERADORES RELACIONAIS
    printf("\n------------------------");
    printf("\nPara x = 5");
    
    x = 5;
    z = 5;
    if (x > 5) // > maior
    {
        printf("\nEste valor e maior que 5"); 
    }
    else
    {
        printf("\nEste valor nao e maior que 5"); 
    }
    if (x < 5) // < menor
    {
        printf("\nEste valor e menor que 5");
    }
    else
    {
        printf("\nEste valor nao e menor que 5");
    }
    if (x >=5) // >= maior ou igual
    {
        printf("\nEste valor e maior ou igual a 5");
    }
    else
    {
        printf("\nEste valor nao e maior ou igual a 5");
    }
    if (x <= 5) // >= menor ou igual
    {
        printf("\nEste valor e menor ou igual a 5");
    }
    else
    {
        printf("\nEste valor nao e menor ou igual a 5");
    }
    if (x != 5) // != diferente de 
    {
        printf("Este valor e diferente de 5");
    }
    else
    {
        printf("\nEste valor nao e diferente de 5");
    }
    if (x == 5) // == igual a
    {
        printf("\nx == 5");
    }
    
    //OPERADORES LÓGICOS
   

    //logica E
     printf("\n------------------------");
    printf("\nx = 5 e z = 5");
    x = 5;
    z = 5;
    if (x = 5 && z == 5)
    {
        printf("X E Z sao IGUAIS a 5");
    }
    
    //logica OU
    printf("\nx = 5 e z = 10");
    x = 5;
    z = 10;
    if (x = 5 || z == 5)
    {
        printf("X e igual a 5");
    }
    
    //OPERADORES TERNARIOS
    x = 5;
    z = x=5? 5: 0 ;
    printf("\nZ = %d", z);
}

