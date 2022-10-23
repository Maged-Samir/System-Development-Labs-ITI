#include <stdio.h>
#include <stdlib.h>

void main()
{
int r,c;
    printf("Enter the number of rows and column\n");
    scanf("%d %d",&r,&c);
    int arr[r][c];
    printf("Enter the elements of the matrix\n");
    for(int i=0;i<r;i++)
    {
        for(int j=0;j<c;j++)
        {
            scanf("%d",&arr[i][j]);
        }
    }
    printf("\nElements in the matrix are \n");
    for(int i=0;i<r;i++)
   {
        for(int j=0;j<c;j++)
        {
            printf("%d ",arr[i][j]);
        }
        printf("\n");
    }
    printf("\nRow Sum\n");
    for(int i=0;i<r;i++)
    {
        int rsum=0;
        for(int j=0;j<c;j++)
        {
            rsum=rsum+arr[i][j];
        }
        printf("\nSum of all the elements in row %d is %d\n",i+1,rsum);
    }
    printf("\nColumn Avarage\n");
    for(int i=0;i<r;i++)
    {
        int csum=0;
        for(int j=0;j<c;j++)
        {
            csum=(csum+arr[j][i]);
        }
        printf("\n Avarage of all the elements in column %d is %d\n",i+1,csum/c);
    }
}
