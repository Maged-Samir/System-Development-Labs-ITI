#include<stdio.h>
#include <windows.h>
int main()
        {

void gotoxy( int column, int line )
  {
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
  }


int c,r,i,size,totalSize=0;

          printf("please enter size of magic box: \t");
          scanf("%d",&size);
          if(size % 2 == 0 && size>1)
          {
           printf("please enter odd number box\n");
          }
          else
          {
              totalSize =size * size ;

          for(i=1;i<=totalSize;i++)
          {
                if(i==1)
                {
                  r =1;
                  c=size/2+1;

                }else if(((i-1) % size) == 0){
                  r++;
                }else{
                  r--; c--;
                  if(r == 0)
                   r = size;
                  if(c == 0)
                   c = size;
                }
                gotoxy(3*c,r);
           printf("%d",i);

          }

          }




          return 0;
        }
