#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>
#define null -32
void textattr(int i)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);

}
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

void draw(int pos ,char menu[][10],int d);

int main()
{
    int i ,pos=0 , flag = 0;
    char menu[3][10]={"New" , "Save" , "Exit"};

    char ch;
do{
    system("cls ||clear");

     draw(pos , menu ,0);

     ch = getch();
     switch(ch)
     {
         case null:
                ch= getch();
                switch(ch)
                    {
                    case 72:  //up
                        pos--;
                        if(pos < 0)
                            pos = 2;
                        break;

                    case 71:  // home
                        pos = 0;

                        break;
                    case  79:  //end
                        pos = 2;
                        break;
                    case 80:  //down
                        pos++;
                        if(pos > 2)
                            pos= 0;
                        break;

                    }
                    break;

          case 13: //enter
              system("cls");
              printf("%s" , menu[pos]);
              if(pos == 2)
                flag = 1;
              getch();
              break;

          case 27:
            flag = 1;
            break;



     }
}while(flag == 0);


    getch();
    return 0;
}

//function

void draw(int pos ,char menu[][10],int d)
{
    int i;

    for(i = 0 ; i< 3 ; i++)
        {
            if(i == pos)
                textattr(0x70);

            if(d==0)
                gotoxy(15,10+(3*i));

            printf("%s" , menu[i]);
            textattr(0x07);
        }
}
