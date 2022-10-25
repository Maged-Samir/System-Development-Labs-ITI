#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <windows.h>
#include <unistd.h>
#define normalpen 0x0f
#define highlightpen 180
#define yellowpen 100
#define bluepen 70
#define enter 0x0d
#define esc 27

typedef struct employee
{int id,age;
    char gender, name[100],Address[200];
    double salary, overtime, deduct;


}employee;


employee e [10] = {0};


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
    int id_temp = 0 , id_flag = 0;
    system("cls");

    printf("Please enter an Empolyee ID betweeen 1 and 10 \n");
    printf("Note: it should not have been used before !!!! \n");
    printf(" ID is #  ");
    scanf("%i",&id_temp);


    id_temp = id_temp -1;


    if (id_temp < 0 || id_temp > 9)
    {
        system("cls");
        return;
    }


    for (int i = 0 ; i < 10; i++)
    {
        if (e[id_temp].age > 0)
        {
            system("cls");
            gotoxy(40,12);
            printf(" The ID has been used before !!!\n");

            gotoxy(35,15);
            textattr(bluepen);
            printf(" Want to override the employees data on # %i ? ", id_temp+1);
            textattr(normalpen);
            gotoxy(40,18);
            printf(" if yes press 'y' else press 'n' ");

            int ch = _getche();


            if (ch == 'n')
                {
                    system("cls");

                    gotoxy(18,15);
                    textattr(yellowpen);
                    printf(" ***** You will get redirected to the (main menu) again in 5 seconds *** ");
                    textattr(normalpen);
                    sleep(5);



                    system("cls");

                    return;
                }
            else if ( ch == 'y')
                { break;}



        }

    }

    system("cls");

    char add_menu [8][30] = {"ID", "age", "gender" , "name", "Address", "salary" ,"overtime", "deduct" };

    int i , current = 0 , exitflag = 0, ch ;

    system("cls");

    for ( i = 0; i < 8; i++)
        {
            gotoxy(5,3+(3*i));

            printf("%s",add_menu[i]);


        }

      gotoxy(15,3);

    e[id_temp].id = id_temp +1;

    printf("%i",e[id_temp].id);

    gotoxy(15,6);
    scanf("%i",&e[id_temp].age);

    _flushall();
    gotoxy(15,9);
    scanf("%c",&e[id_temp].gender);

    _flushall();

    gotoxy(15,12);
    gets(e[id_temp].name);

    gotoxy(15,15);
    gets(e[id_temp].Address);

    gotoxy(15,18);
    scanf("%lf",&e[id_temp].salary);

    gotoxy(15,21);
    scanf("%lf",&e[id_temp].overtime);

    gotoxy(15,24);
    scanf("%lf",&e[id_temp].deduct);

    system("cls");

}

 disp_id()
 {
    int id_temp = 0 , id_flag = 0;
    system("cls");

    printf("Please enter an Empolyee ID  \n");
    printf(" ID is #  ");
    scanf("%i",&id_temp);

    id_temp = id_temp -1;

        if (id_temp < 0 || id_temp > 9)
        {
        system("cls");
        return;
        }

     for (int i = 0 ; i < 10; i++)
    {
        if (e[id_temp].age == 0)
        {
            system("cls");
            gotoxy(35,15);
            textattr(bluepen);
            printf(" The ID # %i has no data !!! Want to register it ? ", id_temp+1);
            textattr(normalpen);
            gotoxy(40,18);
            printf(" if yes press 'y' else press 'n' ");

            int ch = _getche();

            if (ch == 'n')
                {
                    system("cls");

                    gotoxy(18,15);
                    textattr(yellowpen);
                    printf(" ***** You will get redirected to the (main menu) again in 5 seconds *** ");
                    textattr(normalpen);
                    sleep(5);

                    system("cls");

                    return;
                }
            else if ( ch == 'y')
                { add_employee();}



            }
        }

        system("cls");

        e[id_temp].id = id_temp +1;

        double net = e[id_temp].salary + e[id_temp].overtime - e[id_temp].deduct;

    printf(" ID: %i , Name: %s , Net.Salary : %0.02lf \n",e[id_temp].id, e[id_temp].name, net);

    printf("------------------------------------ \n");

    printf("press any key to go back");

    _getch();


    system("cls");


 }


disp_all()
{

    system("cls");

    int id_flag = 0 ;

     for (int i = 0 ; i < 10; i++)
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
           printf("no empolyee data has been entered previously.... \n");
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

delete_id()
{

    int id_temp = 0 , id_flag = 0;
    system("cls");

    printf("Please enter an Empolyee ID betweeen 1 and 10 \n");
    printf("Note: Be sure that you already registered it..... \n");
    printf(" ID is #  ");
    scanf("%i",&id_temp);

    id_temp = id_temp -1;

        if (id_temp < 0 || id_temp > 9)
        {
        system("cls");
        return;
        }

        for (int i = 0 ; i < 10; i++)
        {

            if (e[id_temp].age != 0)
            {
                e[id_temp].age = 0;

                printf(" \n ID #%i has been deleted. \n", id_temp+1);
                printf("------------------------------------ \n");


            id_flag = 1;

            }

        }

       if (id_flag == 0)
       {
           printf("no empolyee data with this id.... \n");
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


delete_name()
{
     char name[50];

    int id_flag = 0;

    system("cls");

    printf("Please enter an Empolyee name to be deleted \n");
    printf("Note: Be sure that you already registered it..... \n");
    printf(" Enter employee name:   ");

    _flushall();
    gets(name);
    for(int i = 0; i < 10; i++)
    {


        if( strcmp(name,e[i].name) == 0)
        {
            e[i].age = 0 ;
            id_flag = 1;

            printf("the user %s with id %i has been deleted",e[i].name,e[i].id);

        }

    }

      if (id_flag == 0)
       {
           printf("no data found to be deleted..... \n");
          printf("press any key to go back");

        _getch();
        system("cls");

       }
       else{

         printf("\n press any key to go back");

        _getch();
        system("cls");

       }
}


int main()
{
    char menu [6][30] = {"new", "display by ID",  "display all" , "delete by id", "delete by name", "Exit" };

    int i , current = 0 , exitflag = 0, ch ;

do{

    textattr(normalpen);



    for ( i = 0; i < 6; i++)
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

                case 1: // Display by id
                    disp_id();
                break;

                case 2: // Display all
                    disp_all();
                break;

                case 3: // delete by id
                    delete_id();
                break;

                case 4: // delete by name
                    delete_name();
                break;

                case 5: // exit
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
                    if (current < 0) current = 5;
                    break;


                case 80 :
                    current ++;
                    if(current >5) current = 0;
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

