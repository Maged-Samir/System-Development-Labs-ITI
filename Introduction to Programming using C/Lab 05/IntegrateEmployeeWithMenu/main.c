#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <windows.h>
#include <unistd.h>
#define normalpen 0x0f
#define highlightpen 180
#define enter 0x0d
#define esc 27

typedef struct employee
{int id,age;
    char gender, name[100],Address[200];
    double salary, overtime, deduct;

}employee;

employee e [3] = {0};


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


  void textattr(int i)
{


	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}


add_employee()
{

    for (int k = 0; k < 3; k++)
    {

    char add_menu [8][30] = {"ID", "age", "gender" , "name", "Address", "salary" ,"overtime", "deduct" };

    int i , current = 0 , exitflag = 0, ch ;

    system("cls");

        for ( i = 0; i < 8; i++)
        {
            gotoxy(5,3+(3*i));

            printf("%s",add_menu[i]);
        }

      gotoxy(15,3);
    e[k].id = k+1;
    printf("%i",k+1);
    gotoxy(15,6);
    scanf("%i",&e[k].age);
    _flushall();
    gotoxy(15,9);
    scanf("%c",&e[k].gender);
    _flushall();
    gotoxy(15,12);
    gets(e[k].name);
    gotoxy(15,15);
    gets(e[k].Address);
    gotoxy(15,18);
    scanf("%lf",&e[k].salary);
    gotoxy(15,21);
    scanf("%lf",&e[k].overtime);
    gotoxy(15,24);
    scanf("%lf",&e[k].deduct);


//        sleep(10);


    system("cls");



    }







}




disp_all()
{
    system("cls");

    int id_flag = 0 ;


     for (int i = 0 ; i < 3; i++)
    {
        if (e[i].age != 0)
        {
            double net = e[i].salary + e[i].overtime - e[i].deduct;

            printf(" ID: %i , Name: %s , Net.Salary : %0.02lf \n",e[i].id, e[i].name, net);

            printf("------------------------------------ \n");
            id_flag = 1;

        }

    }

       if (id_flag == 0)
       {
           printf("no empolyee has been found.... \n");
          printf("press any key to go back");

            _getch();

            system("cls");

       }
       else{

        printf("press any key to go back");

        _getch();
        system("cls");

       }




}


int main()
{


    char menu [3][30] = {"new", "display all" , "Exit" };

    int i , current = 0 , exitflag = 0, ch ;


do{
    textattr(normalpen);



    for ( i = 0; i < 3; i++)
    {

        if (current == i)
            textattr(highlightpen);
        else
        textattr(normalpen);


        gotoxy(5,3+(3*i));


        printf("%s",menu[i]);
    }


    ch = _getch();

    switch (ch)
    {
        case enter:
            switch (current)
            {

                case 0:
                     add_employee();
                break;
                case 1:
                    disp_all();
                break;
                case 2:
                    exitflag = 1 ;
                break;
            }
            break;

        case esc:
            exitflag = 1;
            break;
        case 224 :
            ch = _getch();
            switch(ch)
            {
                case 72 :
                    current --;
                    if (current < 0) current = 2;
                    break;
                case 80 :
                    current ++;
                    if(current >2) current = 0;
                    break;
                case 71:
                    current = 0;
                    break;

                case 79:
                    current = 5;
                    break;
            }
            break;
    }
}
while(exitflag == 0);

}

