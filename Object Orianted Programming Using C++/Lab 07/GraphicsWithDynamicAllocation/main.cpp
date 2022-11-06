#include <iostream>
#include <graphics.h>
#include <windows.h>
#include <conio.h>

using namespace std;

class ShapeColor
{
    int C;

public :

    int GetColor(){return C;}

    void SetColor(int D) {C=D;}

    ShapeColor()
    {

    }
    ShapeColor(int _C=0)
    {
        C=_C;
    }

};


class Point
{
    //MemBerVariables
    int x;
    int y;
public:
    //Constractours
    Point()
    {
        x=y=0;
      //cout << "Point Ctor with less parameter" ;
    }
    Point(int _x,int _y)
    {
        x=_x;
        y=_y;
        //cout << "Point Ctor with parameter" ;
    }
    //Destractour
    ~Point()
    {
        //cout << "Point Destractour" ;
    }

    //Getter
    int GetX(){return x;}
    int GetY(){return y;}
    //Setter
    void SetX(int _x){x=_x;}
    void SetY(int _y){y=_y;}

};

class Rect :public ShapeColor
{
    Point UL;
    Point LR;
    ///int Color;
public:
    Rect():ShapeColor(8)
    {
        //int Color=0;
    }

    Rect(int x1,int y1,int x2,int y2):UL(x1,y1),LR(x2,y2),ShapeColor(8)
    {

    }

    void draw()
    {
        setcolor(GetColor());
        rectangle(UL.GetX(), UL.GetY(), LR.GetX(), LR.GetY());
    }
};

class Line :public ShapeColor
{
    Point x, y;
    //int Color ;
public:
    Line(int x1 , int y1 , int x2, int y2)
        : x(x1, y1), y (x2, y2),ShapeColor(8)
    { }

    void draw()
    {
        setcolor(GetColor());
        line(x.GetX(), x.GetY(), y.GetX(), y.GetY());
    }
};

class Triangle :public ShapeColor
{
    Line one, two, three;
   // int Color;
public:
    Triangle( int oneX , int oneY , int twoX , int twoY , int threeX , int threeY )
        : one( oneX, oneY, twoX, twoY),
          two( twoX, twoY, threeX, threeY),
          three( threeX, threeY, oneX, oneY), ShapeColor(8)
        {

        }

    void draw()
    {
        one.draw();
        two.draw();
        three.draw();
    }
};

class Circle :public ShapeColor
{
    Point center;
    int radius;
    //int color;
public:
    Circle(int centerX = 0, int centerY = 0, int _radius = 0)
        : radius {_radius}, center(centerX, centerY),ShapeColor(8)
        {

        }

    void draw()
    {
        setcolor(GetColor());
        circle(center.GetX(), center.GetY(), radius);
    }
};

class Pic
{
    Rect* Prect;
    Triangle* PTriangle;
    Circle* PCircle;
    Line* PLine;

    int Rnum;
    int Tnum;
    int Cnum;
    int Lnum;
public:
    Pic()
    {
        Rnum=0;
        Tnum=0;
        Cnum=0;
        Lnum=0;
        Prect=NULL;
        PTriangle=NULL;
        PLine=NULL;
        PCircle=NULL;
    }
    Pic(Rect* rarr,int R,Triangle* rarr2,int T, Circle* rarr3,int C, Line* rarr4,int L)
    {
        Prect =rarr;
        PTriangle=rarr2;
        PCircle=rarr3;
        PLine=rarr4;

        Rnum = R;
        Tnum = T;
        Cnum=C;
        Lnum=L;
    }

     void SetRect(Rect* rarr,int R)
    {
        Prect =rarr;
        Rnum = R;
    }

    void SetTriangle(Triangle* rarr2,int T)
    {
        PTriangle=rarr2;
        Tnum=T;
    }

    void SetLine(Line* rarr,int L)
    {
        PLine =rarr;
        Lnum = L;
    }

    void SetCircle(Circle* rarr,int C)
    {
        PCircle =rarr;
        Cnum = C;
    }


    void Paint()
    {
        for (int i=0;i<Rnum;i++)
        {
            Prect[i].draw();
        }

        for (int i=0;i<Cnum;i++)
        {
            PCircle[i].draw();
        }
        for (int i=0;i<Lnum;i++)
        {
            PLine[i].draw();
        }
        for (int i=0;i<Tnum;i++)
        {
            PTriangle[i].draw();
        }
    }

};


int main()
{


    cout << "Drawing Graphics" << endl;

    initgraph();

    /*

    Circle c(140, 80, 80);
    c.draw();

    Triangle tri(139,119,82,246,195,245);
    tri.draw();

    Line left2(107, 249, 107, 350);
    Line right2(161, 249, 161, 350);
    left2.draw();
    right2.draw();

    Rect rec( 259, 352, 25, 412);
    rec.draw();

    char ch;
    cin >> ch;
    return 0;

    */

    Pic p;

    Rect * rarr;
    rarr=new Rect[2];
    rarr[0]=Rect(259, 352, 25, 412);
    rarr[1]=Rect(159, 252, 25, 312);


    Circle * rarr2;
    rarr2=new Circle[1];
    rarr2[0]=Circle(140, 140, 80);


    p.SetRect(rarr,2);
    p.SetCircle(rarr2,1);

    p.Paint();




   // cout << "Drawing Graphics" << endl;

    return 0;
}
