#include <stdio.h>
#include <stdlib.h>

int main()
{
    char name[20];
    printf("your name \t");
    for(int i=0;i<20;i++)
    {
        char ch=_getche();
        if(ch == 0x0d)
        {
            name[i]='\0';
            printf("\n");
            break;
        }
        name[i]=ch;
    }
    printf("entered name is :%s\n",name);
    return 0;
}
