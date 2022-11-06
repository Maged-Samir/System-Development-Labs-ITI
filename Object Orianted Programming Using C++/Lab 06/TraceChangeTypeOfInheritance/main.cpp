#include <iostream>

using namespace std;

class Base
{
    int x;
protected:
    int y;
public:
    int z;
    Base(int _x=0,int _y=0,int _z=0)
    {
        x=_x;
        y=_y;
        z=_z;
    }

    int GetX(){return x;}
    int GetY() {return y;}
    int GetZ() {return z;}

    void SetX(int _x) {x=_x;}
    void Sety(int _y) {y=_y;}
    void SetZ(int _z) {z=_z;}


    int fun ()
    {
        return x+y+z;
    }

};


class Drived : Base
{
    int a;
protected:
    int b;
public:
    int c;
    Drived(int _a=0,int _b=0,int _c=0,int x=0,int y=0,int z=0):Base(x,y,z)
    {
        a=_a;
        b=_b;
        c=_c;
    }

    int GetA(){return a;}
    int GetB() {return b;}
    int GetC() {return c;}

    void SetA(int _a) {a=_a;}
    void SetB(int _b) {b=_b;}
    void SetC(int _c) {c=_c;}

    int fun()
    {
        return a+b+c+
               y+z;
               // X is private in base so we cant access it
    }
};

class SubDrived :Drived
{
    int k;
protected:
    int l;
public:
    int m;
    SubDrived(int _k=0,int _l=0,int _m=0,int a=0,int b=0,int c=0,int x=0,int y=0,int z=0):Drived(a,b,c,x,y,z)
    {
        k=_k;
        l=_l;
        m=_m;
    }

    int GetK(){return k;}
    int GetL() {return l;}
    int GetM() {return m;}

    void SetK(int _k) {k=_k;}
    void SetL(int _l) {l=_l;}
    void SetM(int _m) {m=_m;}


    int fun()
    {
        return k+l+m+
        b+c;
        //we know x is not accessable and also Y&z

    }
};

int main()
{
    cout << "Trace Changing Of Inheritance Type!" << endl;

    Base b;
    //b.x=1;  //not accessable
    //b.y=2;  //not accessable
      b.z=3;


     Drived d;
      //d.x=2;
      //d.y=3;
      //d.z=2;

      //d.a=2;
      //d.b=5;

       d.c=5;


      SubDrived sb ;

      //sb.x=1;
      //sb.y=5;
            //sb.z=4;
      //sb.a=2;
      //sb.b=6;
            //sb.c=5;
      //sb.k=5;
      //sb.l=9;
      sb.m=6;


    return 0;
}
