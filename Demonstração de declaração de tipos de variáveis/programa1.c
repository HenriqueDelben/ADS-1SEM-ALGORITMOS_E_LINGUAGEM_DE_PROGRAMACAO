#include <stdio.h>
#include <string.h> // biblioteca necessária por causa do comando strcpy

int main()
{
    //detalhe, na linguagem C, o tipo "decimal", não é um considerado um tipo primitivo, isto é, que possui um tipo específico para ele. Na linguagem C, por ser somente para efeitos de demonstração, não entraremos dentro deste quesito
    //demonstração declaração e atribuição de valores a uma variavel
    int a = 10;
    float b = 10;
    double c = 10;
    
    //imprimindo na tela os valores numericos
    printf("Double = %d", a);
    printf("\nFloat = %f", b);
    printf("\nDouble = %f", c);

    

    return(0);
}