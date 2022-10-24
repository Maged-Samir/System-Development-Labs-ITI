#include <stdio.h>
#include <stdlib.h>

int main()
{
    char fname[10] , lname[10] ,fullname[20];

    system("cls||clear");
    printf("Enter the first & last name:\n");

    scanf("%s" , fname);
    scanf("%s" , lname);



    strcpy(fullname ,fname);
    strcat(fullname , " ");
    strcat(fullname , lname);

    printf("FullName :%s" , fullname);



    getch();
    return 0;
}
