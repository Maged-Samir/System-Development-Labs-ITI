#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <string.h>

#define lineSize 11


#define Enter 0x0D
#define ESC 27
#define SpecialIndicator -32
#define Up 72
#define Down 80
#define Right 77
#define Left 75
#define Home 71
#define End 79


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


void lineEditor(int x, int y, char Schar, char Echar, char *line)
{
    int sCol = x, cCol = x, eCol = x, maxCol = x + lineSize, exitFlag = 0;
    char key;

    do
    {

        gotoxy(cCol, y);
        key = _getch();

        switch (key)
        {

        case SpecialIndicator:

            key = _getch();

            switch (key)
            {

            case Left:

                cCol = cCol > sCol ? cCol - 1 : cCol;
                break;

            case Right:

                cCol = cCol < eCol ? cCol + 1 : cCol;
                break;

            case Home:

                cCol = sCol;
                break;

            case End:

                cCol = eCol;
                break;
            }

            break;

        case Enter:

            exitFlag = 1;
            break;

        case ESC:

            cCol = eCol;
            break;

        default:

            if (cCol < maxCol && ((key >= Schar && key <= Echar) || key == ' '))
            {

                line[cCol - x] = key;

                printf("%c", key);

                if (cCol == eCol)
                {
                    eCol++;
                }

                cCol++;
            }
        }
    }
    while (!exitFlag);
}

int main()
{
    char line[lineSize + 1];

    printf("Enter your string : \n");

    lineEditor(0,3, 65,122, line);

    printf("Your String is:\n");
    puts(line);
    return 0;
}
