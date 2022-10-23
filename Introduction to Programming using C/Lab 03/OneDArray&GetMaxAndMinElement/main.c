#include <stdio.h>
#include <stdlib.h>

void main()
{
    int Arr[4];
    int max, min;
  printf("Enter your elements:\n");

  for(int i = 0; i < 4; ++i) {
     scanf("%d", &Arr[i]);
  }

    max = Arr[0];
    min = Arr[0];

  printf("Your elements are:\n");

  for(int i = 0; i < 4; ++i) {
     printf("%d\n", Arr[i]);
  }
//get Max and Min Of Entered element
  for(int i=1; i<4; i++)
    {

        if(Arr[i] > max)
        {
            max = Arr[i];
        }


        if(Arr[i] < min)
        {
            min = Arr[i];
        }
    }
    printf("Max element = %d\n", max);
    printf("Min element = %d", min);

}
