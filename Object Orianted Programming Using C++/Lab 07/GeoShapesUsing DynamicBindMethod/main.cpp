#include <iostream>
#include <windows.h>

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

    virtual double CalcArea()
    {
        return 0;
    }

};

class Rect:public GeoShape
{
   public:
       Rect()
       {

       }
       Rect(int w,int h):GeoShape(w,h)
       {

       }
       double CalcArea() override
       {
           return Dim1 * Dim2;
       }
};

class Square:public Rect
{
public:
    Square()
    {

    }
    Square(int l):Rect(l,l)
    {

    }
    double CalcArea() override
       {
           return Dim1 * Dim2;
       }

};

class Circle:public GeoShape
{
public:
    Circle()
    {

    }

    Circle(int r):GeoShape(r,r)
    {

    }

    double CalcArea() override
    {
        return 3.14 * Dim1 * Dim2;
    }
};

class Triangle :public GeoShape
{
public:
    Triangle()
    {

    }
    Triangle(int d1,int d2):GeoShape(d1,d2)
    {

    }


    double CalcArea() override
    {
        return 0.5*Dim1,Dim2;
    }
};


// standalone function for Single Objects
double TotalAreas(Rect &r, Square &s,Triangle &t,Circle &c)
{
    double result;

    result=r.CalcArea() + s.CalcArea() + t.CalcArea() +c .CalcArea();

    return result;
}

//Standalone Function For Multi Objects Shapes
double TotalAreas(Circle* cPtr, Rect* rPtr,
               Square* sPtr, Triangle* tPtr)
{
    double result = 0;
    int size;

    for (int i = 0; i < size; i++)
    {
        result += cPtr[i].CalcArea();
    }
    for (int i = 0; i < size; i++)
    {
        result += rPtr[i].CalcArea();
    }
    for (int i = 0; i < size; i++)
    {
        result += sPtr[i].CalcArea();
    }
    for (int i = 0; i < size; i++)
    {
        result += tPtr[i].CalcArea();
    }

    return result;
}

//Standalone Function For Multi Objects Shapes
//Using Dynamic binded Method

double TotalAreas(GeoShape** GArr ,int c)
{
    double result =0;
    for (int i=0;i<c;i++)
        result+=GArr[i] ->CalcArea();
}




int main()
{
    cout << "Geometric Shapes!" << endl;

cout << "***********************************************" << endl;

    Rect r(10,5);
    cout << "Rect Area = " << r.CalcArea() << endl;

    Square s(10);
    cout << "Square Area = " << s.CalcArea() << endl;

    Triangle t(10,5);
    cout << "Triagle Area = " << t.CalcArea() << endl;

    Circle c(10);
    cout << "Circle Area = " << c.CalcArea() << endl;

    cout << "total Areas= " << TotalAreas(r,s,t,c)<< endl;

    cout << "***********************************************" << endl;

    /*

  int d1,d2;

  Rect r11[2];
  cout << " Rectangles Data \n";

  // Accessing the function
  for(int i = 0; i < 2; i++)
  {
        cout << "width of rectangle " << i+1 << ": ";
        cin >> d1;
        cout << "height of rectangle " << i+1 << ": ";
        cin >> d2;
        r11[i] = Rect(d1, d2);
  }

  Square s11[2];
  cout << " Square Data --------------------\n ";

  // Accessing the function
  for(int i = 0; i < 2; i++)
  {
        cout << "side of triangle " << i+1 << ": ";
        cin >> d1;
        s11[i] = Square(d1);

  }

    Triangle t11[2];
  cout << " Triangle Data --------------------\n";

  // Accessing the function
  for(int i = 0; i < 2; i++)
  {
        cout << "base of triangle" << i+1 << ": ";
        cin >> d1;
        cout << "height of triangle" << i+1 << ": ";
        cin >> d2;
        t11[i] = Triangle(d1, d2);

  }



  Circle c11[2];
  cout << " Circles Data --------------------\n";

  // Accessing the function
  for(int i = 0; i < 2; i++)
  {
       cout << "radius of circle " << i+1 << ": ";
        cin >> d1;
        c11[i] = Circle(d1);
  }


     cout << "total areas of all objects = " << TotalAreas(c11, r11,s11, t11) << endl;;

*/
cout << "***********************************************" << endl;

/*
     GeoShape *ptr=new Square(20);
     cout << "Area Of one Square = " << ptr->CalcArea() << endl;



      Rect arr1[2]={Rect(10,15),Rect(2,3)};
      Triangle arr2[2]={Triangle(3,2),Triangle(2,3)};
      Circle arr3[1]={Circle(2)};


     GeoShape* arr[5]={arr1,&arr1[1],arr2,&arr2[1],arr3};
     cout << "total areas by dynamic bind = " << totalOfsum(arr,5) <<endl;

*/

     Rect arr1[2]={Rect(1,2),Rect(2,2)};
     Triangle arr2[2]={Triangle(2,2),Triangle(3,5)};
     Circle arr3[1]={Circle(3)};

     GeoShape* NewArr[5]={&arr1[0],&arr1[1],&arr2[0],&arr2[1],&arr3[0]};
     cout << TotalAreas(NewArr,5);


     return 0;
}
