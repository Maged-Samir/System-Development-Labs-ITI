#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>

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

struct employee
{
    int ID,Age;
    char Name,Adress[100];
    double Salary,Overtime,Tax;
};


void main()
{
    struct employee Emp;

    gotoxy(5,10);
    printf("ID:\n");
    gotoxy(5,13);
    printf("Name:\n");
    gotoxy(5,16);
    printf("Age:\n");
    gotoxy(5,19);
    printf("Address:\n");
    gotoxy(5,22);
    printf("Salary\n");
    gotoxy(5,25);
    printf("Overtime\n");
    gotoxy(5,28);
    printf("Tax\n");




    gotoxy(12,10);
    scanf("%d",&Emp.ID);
     _flushall();
    gotoxy(12,13);
    gets(Emp.Name);
    gotoxy(12,16);
    scanf("%d",&Emp.Age);
     _flushall();
    gotoxy(12,19);
    gets(Emp.Adress);
    gotoxy(12,22);
    scanf("%d",&Emp.Salary);
    gotoxy(12,25);
    scanf("%d",&Emp.Overtime);
    gotoxy(12,28);
    scanf("%d",&Emp.Tax);
    gotoxy(12,31);

    gotoxy(20,33);
    printf("netsalary= %d",(Emp.Salary+Emp.Overtime)-Emp.Tax);

}
