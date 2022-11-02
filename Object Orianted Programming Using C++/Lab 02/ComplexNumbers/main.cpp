#include <iostream>

using namespace std;

class Complex
{
    //Member Variables Of Class
   int Real;
   int Img;

public:
    //Getter
    int GetReal()
    {
        return Real;
    }
    int GetImg()
    {
        return Img;
    }
    //Setter
    void SetReal(int _Real)
    {
        Real=_Real;
    }
    void SetImg(int _Img)
    {
        Img=_Img;
    }

    //Constractours
    Complex(int R=0,int I=0)
    {
        Real=R;
        Img=I;
        cout << "Constractour" << endl;
    }

    ~Complex()
    {
        cout << "Destractour" << endl;
    }

    //Member Functions Of Class
    void print()
    {
        bool real_is_zero = false;

        if(Img == 0 && Real == 0)
        {
            cout << 0 << endl;
            return;
        }

        if(Real != 0) cout << Real;
        else real_is_zero = true;

        if(Img != 0){
            if(Img > 0 && !real_is_zero) cout << '+';

            cout << Img << 'i';
        }

        cout << endl;
    }

    Complex sum(Complex r)
    {
        Complex result;

        result.SetReal(GetReal() + r.GetReal());
        result.SetImg(GetImg() + r.GetImg());

        return result;
    }


};

// stand alone function to subtract two complex numbers
Complex sub(Complex &L, Complex &R)
{
    Complex result;

    result.SetReal(L.GetReal() - R.GetReal());
    result.SetImg(L.GetImg() - R.GetImg());

    return result;
}


int main()
{
    cout << "Represent Complex Numbers With Classes" << endl;


    Complex C1 ,C2;

    C1.SetReal(1);
    C1.SetImg(2);

    C2.SetReal(2);
    C2.SetImg(2);

    cout << "C1 = ";
    C1.print();
    cout << "C2 = ";
    C2.print();

    cout << endl;

    cout << "C1 + C2 = ";
    Complex Result = C1.sum(C2);
    Result.print();


    cout << "C1 - C2 = ";
    Complex result2 = sub(C1, C2);
    result2.print();


    return 0;
}
