#include <iostream>

using namespace std;

class GeoShape
{
protected:
    int Dim1,Dim2;
public:
    GeoShape(int d1=0,int d2=0)
    {
        Dim1=d1;
        Dim2=d2;
    }

    int GetDim1(){return Dim1;}
    int GetDim2() {return Dim2;}


    void SetDim1(int D) {Dim1=D;}
    void SetDim2(int D) {Dim2=D;}

};

class Rect:public GeoShape
{
   public:
       Rect(int w,int h):GeoShape(w,h)
       {

       }
       int CalcArea()
       {
           return Dim1 * Dim2;
       }
};

class Square:public Rect
{
public:
    Square(int l):Rect(l,l)
    {

    }

};

class Circle:public GeoShape
{
public:
    Circle(int r):GeoShape(r,r)
    {

    }

    double CalcArea()
    {
        return 3.14 * Dim1 * Dim2;
    }
};

class Triangle :public GeoShape
{
public:
    Triangle(int d1,int d2):GeoShape(d1,d2)
    {

    }


    double CalcArea()
    {
        return 0.5*Dim1,Dim2;
    }
};


// stand alone function
double TotalAreas(Rect &r, Square &s,Triangle &t,Circle &c)
{
    double result;

    result=r.CalcArea() + s.CalcArea() + t.CalcArea() +c .CalcArea();

    return result;
}

int main()
{
    cout << "Geometric Shapes!" << endl;

    Rect r(10,5);
    cout << "Rect Area = " << r.CalcArea() << endl;

    Square s(10);
    cout << "Square Area = " << s.CalcArea() << endl;

    Triangle t(10,5);
    cout << "Triagle Area = " << t.CalcArea() << endl;

    Circle c(10);
    cout << "Circle Area = " << c.CalcArea() << endl;

    cout << "total Areas= " << TotalAreas(r,s,t,c)<< endl;
    return 0;
}
