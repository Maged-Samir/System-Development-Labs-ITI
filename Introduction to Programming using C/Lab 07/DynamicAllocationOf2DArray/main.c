#include <stdio.h>
#include <stdlib.h>

int main()
{
   int **Marks,StdN,SubN,  i,j,*Sum, *Avg;

   printf("Enter the number of students :");
   scanf("%i",&StdN);

   printf("\n");

   _flushall();

   printf("Enter the number of Subjects :");
   scanf("%i",&SubN);


   Marks = (int**) malloc(StdN * sizeof(int*));

   for (i = 0; i < StdN; i++)
   {

       Marks[i] = (int*) malloc(SubN * sizeof(int));
   }

   Sum = (int*) malloc(StdN * sizeof(int));
   Avg = (int*) malloc(SubN * sizeof(int));


   for(i=0; i < StdN; i++)
        Sum[i] = 0;

    for(j=0; j < SubN; j++)
        Avg[j] = 0;


    for (i = 0; i < StdN; i++)
    {
        for(j = 0; j < SubN; j++)
        {


            printf("Enter marks for Student (%i) on subject (%i)  : ", i+1, j+1);
            scanf("%i",&Marks[i][j]);

            Sum[i] += Marks[i][j];

            Avg[j] += Marks[i][j];

        }

        printf("\n");
    }

    for(j = 0; j < SubN; j++ )
    {
        Avg[j] /= StdN;
    }

    // printing the array.
    for (i = 0; i < StdN; i++)
    {
        for(j = 0; j < SubN; j++)
        {
            printf("%i   ",Marks[i][j]);

        }

        printf("\n");
    }

    for(i=0; i < StdN; i++)
        {
            printf("Sum of marks for student (%i) is : %i \n", i+1, Sum[i]);
        }


        printf("\n");

    for(j=0; j < SubN; j++)
    {
        printf("Avg mark of subject (%i) is : %i  \n", j+1, Avg[j]);
    }

        for(i = 0; i < StdN; i++)
            free(Marks[i]);

        free(Marks);
}
