#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
#include <string.h>

#define MenuCount 6
#define EmpCount 10
#define lineSize 10

#define NotFound "\nThis employee wasn't found.\n"

#define NormalPen 0x0F
#define HighLightPen 0XF0
#define Enter 0x0D
#define ESC 27
#define SpecialIndicator -32
#define Up 72
#define Down 80
#define Right 77
#define Left 75
#define Home 71
#define End 79


typedef struct Employee
{
    int ID, Age;
    char Gender, Name[100], Address[200];
    double Salary, OverTime, Deduct;
} Employee;

/*
    function to colorize output
*/
void textattr (int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}

/*
    function to move cursor to x, y
*/
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

/*
    get x position of form element number i
*/
int getX(int i)
{
    return (i/6)*35+15;
}

/*
    get y position of form element number i
*/
int getY(int i)
{
    return (i%6)*3+3;
}

/*
    go to the place where user will enters input number i
*/
void gotoIInput(int i)
{
    gotoxy(getX(i), getY(i));
}

/*
    print spaces in the current input
*/
void printSpaces(i)
{
    gotoIInput(i);
    for (int i = 0; i < lineSize; i++)
        printf(" ");
    gotoIInput(i);
}

/*
    Highlight current input
*/
void highlightInput(int i)
{
    textattr(HighLightPen);
    printSpaces(i);
}

/*
    Normal pen with current input
*/
void lowlightInput(int i, char *line)
{
    // reset pen
    textattr(NormalPen);
    // go to the beginning of the input
    gotoIInput(i);

    // print current line
    printf("%s", line);

    // get string length and print the reminder spaces
    int len = strlen(line);
    for (int j = 0; j < lineSize - len; j++)
        printf(" ");
}


/*
    fills line with accepted characters only and prints to the console
    x: column, y: row, Schar: first character in range, Echar: last char in range, line: char array to be edited
*/
void lineEditor(int x, int y, char Schar, char Echar, char *line)
{
    int sCol = x, cCol = x, eCol = x, maxCol = x + lineSize, exitFlag = 0;
    char key;

    do
    {
        // go to current place
        gotoxy(cCol, y);
        // get user input without printing
        key = _getch();
        // handle input
        switch (key)
        {
        // extended keys
        case SpecialIndicator:

            key = _getch(); // get next button from buffer

            switch (key) // handle extended keys
            {

            case Left:
                // go left if the cursor is after the start
                cCol = cCol > sCol ? cCol - 1 : cCol;
                break;

            case Right:
                // go right if the cursor is before the last character
                cCol = cCol < eCol ? cCol + 1 : cCol;
                break;

            case Home:
                // go to the beginning of the line
                cCol = sCol;
                break;

            case End:
                // go to the end of the line
                cCol = eCol;
                break;
            }

            break;

        case Enter:
            // break the input loop
            exitFlag = 1;
            break;

        case ESC:
            textattr(NormalPen);
            system("cls");
            _Exit(0);
            break;

        default: // other non-extended keys

            // if there still a place in the line
            if (cCol < maxCol && ((key >= Schar && key <= Echar) || key == ' '))
            {
                // add key to the line
                line[cCol - x] = key;
                // print it to the screen
                printf("%c", key);
                // if we are at the end of the line
                if (cCol == eCol)
                {
                    // expand the line position
                    eCol++;
                }
                // move the cursor
                cCol++;
            }
        }
    }
    while (!exitFlag);
}

/*
    get integer for current input
*/
int getInt(int i)
{
    // buffer
    char line[lineSize + 1] = {};

    // get input and make sure it's not empty
    do
    {
        highlightInput(i);
        lineEditor(getX(i), getY(i), 48, 57, line);
    }
    while (strcmp(line, "") == 0);

    lowlightInput(i, line);

    return atoi(line);
}

/*
    get double for current input
*/
int getDouble(int i)
{
    // buffer
    char line[lineSize + 1] = {};

    do
    {
        highlightInput(i);
        lineEditor(getX(i), getY(i), 46, 57, line);
    }
    while (strcmp(line, "") == 0);

    lowlightInput(i, line);

    char *tempChar;
    return strtod(line, &tempChar);
}

/*
    get string for current input
*/
void getString(int i, char *line)
{
    do
    {
        highlightInput(i);
        lineEditor(getX(i), getY(i), 65, 122, line);
    }
    while (strcmp(line, "") == 0);


    lowlightInput(i, line);
}

/*
    function to prints new employee form and gets information from user
*/
Employee getEmployee()
{
    Employee emp;
    char formEntries[8][12] = {"ID        :", "Age       :", "Gender:", "Name      :", \
                               "Address   :", "Salary    :", "Over  Time:", "Deduct    :"
                              };

    // print form
    for (int i = 0; i < 8; i++)
    {
        gotoxy((i/6)*35+3, (i%6)*3+3);
        puts(formEntries[i]);
    }

    _flushall();



    // get form enteries from user
    int i = 0;

    emp.ID = getInt(i++);

    emp.Age = getInt(i++);

    // get gender, make sure it's M or F
    highlightInput(i);
    do
    {
        gotoIInput(i);
        for (int i = 0; i < lineSize; i++)
            printf(" ");
        gotoIInput(i);
        scanf("%c", &emp.Gender);
    }
    while (emp.Gender != 'M' && emp.Gender != 'F');
    lowlightInput(i++, &emp.Gender);

    _flushall();

    char name[lineSize + 1] = {};
    // get name, make sure it's not empty
    getString(i++, name);
    strcpy(emp.Name, name);


    char address[lineSize + 1] = {};
    // get address, make sure it's not empty
    getString(i++, address);
    strcpy(emp.Address, address);

    emp.Salary = getDouble(i++);

    emp.OverTime = getDouble(i++);

    emp.Deduct = getDouble(i++);

    _flushall();

    return emp;
}

/*
    prints employee summary using its index in the emp array
*/
void displayEmployeeIndex(Employee *emp, int i)
{
    printf("\n%i. %s, $%.2lf\n\n", emp[i].ID, emp[i].Name, emp[i].Salary + emp[i].OverTime - emp[i].Deduct);
}

/*
    displays all employees from emp array
*/
void displayEmployees(Employee *emp)
{
    // records if the list empty or not
    int empty = 0;
    for (int i = 0; i < EmpCount; i++)
    {
        // display Employee info if exists
        if (strcmp("", emp[i].Name) != 0)
        {
            empty++;
            displayEmployeeIndex(emp, i);
        }
    }

    if (!empty)
        printf("There are no employees, yet");
}

/*
    displays an employee from the emp Arr using its ID
*/
void displayEmployeeID(Employee *emp, int id)
{
    for (int i = 0; i < EmpCount; i++)
    {
        // display Employee info if the ID matches
        if (id == emp[i].ID && strcmp("", emp[i].Name) != 0)
        {
            displayEmployeeIndex(emp, i);
            return;
        }
    }

    printf(NotFound);
}

/*
    delete an employee from the emp Arr using its index, and shift all other elements left
    up to currentEmp
*/
void deleteEmployeeIndex(Employee *emp, int index, int currentEmp)
{
    currentEmp = currentEmp == EmpCount ? currentEmp - 1 : currentEmp;

    for (int i = index; i < currentEmp - 1; i++)
    {
        emp[i] = emp[i+1];
    }

    emp[currentEmp - 1].ID = -1;
    strcpy(emp[currentEmp - 1].Name, "");
}


int areYouSureDelete(Employee *emp, int index, int currentEmp)
{
    displayEmployeeIndex(emp, index);
    char sure;
    do
    {
        printf("Are you sure you want to delete this employee? (y/n)\n");
        scanf("%c", &sure);
    }
    while (sure != 'y' && sure != 'n');

    if (sure == 'y')
    {
        deleteEmployeeIndex(emp, index, currentEmp);
        return 1;
    }
    else
    {
        return 0;
    }
}

/*
    delete an employee from the emp Arr using its ID, and shift all other elements left
    up to currentEmp
*/
int deleteEmployeeID(Employee *emp, int id, int currentEmp)
{
    for (int i = 0; i < EmpCount; i++)
    {
        // delete Employee info if the ID matches
        if (id == emp[i].ID && strcmp("", emp[i].Name) != 0)
        {
            // ask the user if he is sure to delete this emp
            return areYouSureDelete(emp, i, currentEmp);
        }
    }

    printf(NotFound);

    return 0;
}


/*
    delete an employee from the emp Arr using its Name, and shift all other elements left
    up to currentEmp
*/
int deleteEmployeeName(Employee *emp, char name[100], int currentEmp)
{
    for (int i = 0; i < EmpCount; i++)
    {
        // delete Employee info if the name matches
        if (strcmp(name, emp[i].Name) == 0 && strcmp("", emp[i].Name) != 0)
        {
            // ask the user if he is sure to delete this emp
            return areYouSureDelete(emp, i, currentEmp);
        }
    }

    printf(NotFound);

    return 0;
}

/*
    returns the first index of emp having the same id, returns -1 if not found
*/
int findId(Employee *emp, int id)
{
    for (int i = 0; i < EmpCount; i++)
    {
        if (emp[i].ID == id && strcmp("", emp[i].Name) != 0)
        {
            return i;
        }
    }

    return -1;
}


void waitKey()
{
    _flushall();
    printf("\n\n\n(press any key to continue)");
    _getch();
    _flushall();
}


int main()
{

    char menu[MenuCount][15] = {"New", "Display By ID", "Display All",
                                "Delete By ID", "Delete By Name", "Exit"},
         key, nameTemp[100];

    int current = 0, exitFlag = 0, empIndex = 0, ID;
    // array of employees
    Employee emp[EmpCount] = {}, empTemp = {};
    do
    {
        system("cls");

        // print menu entries
        for (int i = 0; i < MenuCount; i++)
        {
            // highlight current
            if (current == i)
                textattr(HighLightPen);


            gotoxy(5, 3+3*i);
            // print this entry
            puts(menu[i]);
            // reset text color
            textattr(NormalPen);
        }

        // get user input
        key = _getch();

        // react to user input
        switch (key)
        {
        case ESC:
            exitFlag = 1;
            break;

        case Enter:
            // do current entry
            switch (current)
            {
            case 0: // new
                system("cls");
                // if there is a place for a new emp
                if (empIndex < EmpCount)
                {
                    // get emp info
                    empTemp = getEmployee();

                    // checks if the ID already exists
                    int found = findId(emp, empTemp.ID);

                    // if not found
                    if (found == -1)
                        emp[empIndex++] = empTemp;
                    else // if found, ask the user to be replaced
                    {
                        char replace;

                        system("cls");

                        _flushall();

                        do
                        {
                            printf("\nThis ID exists:");
                            displayEmployeeIndex(emp, found);
                            printf("Do you want to replace him/her? (y/n)\n");
                            scanf("%c", &replace);
                        }
                        while(replace != 'y' && replace != 'n');

                        _flushall();

                        if (replace == 'y')
                            emp[found] = empTemp;

                        waitKey();
                    }
                }
                else // there is no empty place for a new emp
                {
                    printf("You've entered all three employees.");
                    waitKey();
                }
                break;

            case 1: // display by ID
                system("cls");
                _flushall();
                printf("Please enter the employee ID to be displayed: ");
                scanf("%i", &ID);
                _flushall();
                displayEmployeeID(emp, ID);
                waitKey();
                break;

            case 2: // display all
                system("cls");
                displayEmployees(emp);
                waitKey();
                break;

            case 3: // delete by ID
                system("cls");
                printf("Please enter the employee ID to be DELETED: ");
                _flushall();
                scanf("%i", &ID);
                _flushall();
                if (deleteEmployeeID(emp, ID, empIndex))
                    empIndex--;
                waitKey();
                break;

            case 4: // delete by Name
                system("cls");
                printf("Please enter the employee Name to be DELETED: ");
                _flushall();
                gets(nameTemp);
                if (deleteEmployeeName(emp, nameTemp, empIndex))
                    empIndex--;
                waitKey();
                break;

            case 5: // exit
                exitFlag = 1;
                break;
            }

            break;

        case SpecialIndicator: // extended keys

            // read from buffer
            key = _getch();

            // perform key
            switch (key)
            {
            case Up:
                current = !current ? MenuCount-1 : current - 1;
                break;

            case Down:
                current = current == MenuCount-1 ? 0 : current + 1;
                break;

            case Home:
                current = 0;
                break;

            case End:
                current = MenuCount-1;
                break;
            }

            break;
        }
    }
    while (!exitFlag);

    return 0;
}
