#include <iostream>

using namespace std;

int CountCtor,CountDes,CountCopyCtor=0;

class Complex
{
    int real;
    int imaginary;
    char op;
    char getOp()
    {
        return op;
    }

    void setOp()
    {
        op = getImaginary() < 0 ? '-' : '+';
    }

public:

    int getReal()
    {
        return real;
    }

    int getImaginary()
    {
        return imaginary;
    }

    void setReal(int r)
    {
        real = r;
    }

    void setImaginary(int i)
    {
        imaginary = i;

        setOp();
    }

    //Ctor
    Complex(int R ,int I)
    {
        real=R;
        imaginary=I;
        /*
        cout << endl;
        cout << "Ctor Created";
        cout << endl;
        */
        CountCtor++;
    }
    Complex()
    {
        /*
        cout << endl;
        cout << "Ctor Created";
        cout << endl;
        */
         CountCtor++;
    }

    // Copy constructor
    Complex(const Complex& c)
    {
        real = c.real;
        imaginary = c.imaginary;
        /*
        cout << endl;
        cout << "Copy Ctor Created";
        cout << endl;
        */
         CountCopyCtor++;
    }


    void print()
    {

        if (getReal() != 0)
        {
            cout << getReal() << " ";
        }


        if (getImaginary() != 0)
        {

            if (getReal() != 0)
                cout << getOp() << " " << abs(getImaginary()) << "i";

            else
                cout << getImaginary() << "i";
        }


        if (getReal() == 0 && getImaginary() == 0)
        {
            cout << 0;
        }

        cout << endl;
    }

    Complex sum(Complex &r)
    {
        Complex result;

        result.setReal(getReal() + r.getReal());
        result.setImaginary(getImaginary() + r.getImaginary());

        return result;
    }

    ~Complex()
    {
        /*
        cout << endl;
        cout << "Destractour Created";
        cout << endl;
        */
        CountDes++;
    }
};


// stand alone function
Complex sub(Complex &l, Complex &r)
{
    Complex result;

    result.setReal(l.getReal() - r.getReal());
    result.setImaginary(l.getImaginary() - r.getImaginary());

    return result;
}


int main()
{
    Complex c1;
    Complex c2;
    Complex c3;


    c1.setReal(9);
    c2.setReal(-2);



    c1.setImaginary(3);
    c2.setImaginary(2);



    c1.print();
    c2.print();



    cout << endl;

    cout << "first + second (member function) = ";
    Complex _result = c1.sum(c2);
    _result.print();

    cout << "first - second (outer function) = ";
    Complex _result2 = c1.sum(c2);
    _result2 = sub(c1, c2);
    _result2.print();


    cout << " Constractours " << CountCtor ;
    cout << " Destractour " << CountDes ;

    cout << endl;

    //Copy Constractour Called
    Complex obj2(c1); //or obj2=obj1;
    obj2.print();

    return 0;
}
