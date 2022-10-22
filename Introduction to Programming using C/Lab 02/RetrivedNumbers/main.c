#include <stdio.h>
#include <stdlib.h>

int main()
{
    int sum =0;
    int num =0;
    do
    {
     printf("enter your number : ");
     scanf("%i",&num);
     sum+=num;
    }while(sum<100);
        printf("your summition is :%i \n",sum);
}
