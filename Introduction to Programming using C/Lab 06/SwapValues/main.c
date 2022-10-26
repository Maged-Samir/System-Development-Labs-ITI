#include <stdio.h>
#include <stdlib.h>
void swap(int* x ,int* y);

int main()
{
    int x = 10 , y = 15 , z;
    printf(" Original values : x= %d and y= %d \n" , x ,y);


    SwapValue(&x,&y);
    printf(" Swap by Value   : x= %d and y= %d \n" , x ,y);

    SwapAddress(&x,&y);
    printf(" Swap by Address : x= %d and y= %d \n" , x ,y);

    return 0;
}
void SwapValue(int x ,int y)
{

    int temp = x;
        x = y;
        y = temp;


}

void SwapAddress(int* x ,int* y)
{
    int temp = *x;
        *x = *y;
        *y = temp;
}
