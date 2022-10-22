#include <stdio.h>
#include <stdlib.h>

void main()
{
    char choice=0;

 printf("Menu\n\n");
 printf("1. Google\n");
 printf("2. Facebook\n");
 printf("3. Youtube\n");
 scanf("%c",&choice);

 switch (choice)
 {
     case '1':
      printf("\n\nYOU SELECTED Google\n");
      break;
     case '2':
      printf("\n\nYOU SELECTED Facebook\n");
      break;
     case '3':
      printf("\n\nYOU SELECTED Youtube\n");
      break;
     default: printf("Wrong Choice\n");
      break;
 }

}
