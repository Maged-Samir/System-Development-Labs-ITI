#include <iostream>
#include <conio.h>
#include <string>
#include <cstring>


using namespace std;


class Complex
{
    int real;
    int imaginary;
    char op;

    
   

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

    Complex(int R=0 ,int I=0)
    {
        real=R;
        imaginary=I;
    }

    
    void print() const{
        bool real_is_zero = false;

        if(imaginary == 0 && real == 0)
        {
            cout << 0 << endl;
            return;
        }

        if(real != 0) cout << real;
        else real_is_zero = true;

        if(imaginary != 0){
            if(imaginary > 0 && !real_is_zero) cout << '+';

            cout << imaginary << 'i';
        }

        cout << endl;
    }


    //Member Function
    Complex sum(Complex r)
    {
        Complex result;

        result.setReal(getReal() + r.getReal());
        result.setImaginary(getImaginary() + r.getImaginary());

        return result;
    }

    //Operator Overloading Sum
    Complex operator+( Complex &c)
    {
        Complex result;

        result.setReal(getReal() + c.getReal());
        result.setImaginary(getImaginary() + c.getImaginary());

        return result;
    }
    //C1+7
    Complex operator+( int R)
    {
        Complex result (real+R,getImaginary());
        return result;
    }

    //C1-C2
    Complex operator - (Complex c)
    {
        return {real-c.real,imaginary-c.imaginary};
    }

    //C3 - 5
    Complex operator - (int i)
    {
        return {real - i, imaginary};
    }

    //C2+=C1
     Complex& operator += (Complex c)
     {
        real += c.real;
        imaginary += c.imaginary;
        return *this;
     }
    //C2-=C1
     Complex& operator -= (Complex c)
     {
        real -= c.real;
        imaginary -= c.imaginary;
        return *this;
     }

     //C1==C2
     bool operator == (Complex c)
     {
        return (real == c.real) && (imaginary == c.imaginary);
     }

     bool operator >= (Complex c)
     {
        if(real>c.real) return true;
        if(real == c.real && imaginary > c.imaginary) return true;
        if(real == c.real && imaginary == c.imaginary) return true;
        else return false;
     }

     bool operator <= (Complex c)
     {
        if(real<c.real) return true;
        if(real == c.real && imaginary < c.imaginary) return true;
        if(real == c.real && imaginary == c.imaginary) return true;
        else return false;
     }

      bool operator > (Complex c)
      {
        return (real > c.real) || (imaginary > c.imaginary);
      }

    bool operator < (Complex c)
    {
        return (real < c.real) || (imaginary < c.imaginary);
    }

    //++C3
    Complex& operator ++ (){
        real++;
        return *this;
    }
   //--C2
    Complex operator -- (){
        real--;
        return *this;
    }
   //C3++
     Complex operator ++ (int)
     {
        Complex tmp(*this);
        real++;
        return tmp;
     }
    //C2--
    Complex operator -- (int)
    {
        Complex tmp(*this);
        real--;
        return tmp;
    }

    operator int()
    {
        return real;
    }

};

    //7+C1
    Complex operator+( int L , Complex & R)
    {
        Complex result =(L+R.getReal(),R.getImaginary());
        return result;
    }




// stand alone function to subtract two complex numbers
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


    c1.setReal(4);
    c2.setReal(-6);
    c3.setReal(0);


    c1.setImaginary(3);
    c2.setImaginary(-5);
    c3.setImaginary(3);

    cout << "C1 = ";
    c1.print();
    cout << "C2 = ";
    c2.print();
    cout << "C3 = ";
    c3.print();


    cout << endl;

    cout << "C1 + C2 = ";
    Complex result = c1.sum(c2);
    result.print();

    cout << "C1 - C2 = ";
    Complex result2 = c1.sum(c2);
    result2 = sub(c1, c2);
    result2.print();

    cout << "C1 + 7 = ";
    Complex result4 = c1+7;
    result4.print();


    cout << "1 + C3 = ";
    Complex result5 = 1 + c3;
    result5.print();

    cout << "C2 - c3 = ";
    Complex result6 = c2- c3;
    result6.print();

    cout << "C3 - 5 = ";
    Complex result7 = c3-5;
    result7.print();

    cout << "C1 += C2 = ";
    Complex result8 = c1+= c2 ;
    result8.print();

    cout << "C3 -= 0 = ";
    Complex result9 = (c3-= 0) ;
    result9.print();

    cout << "C3==C1 = ";
    Complex result10 = c3==c1 ;
    result10.print();

    cout << "C1 >= C2: " << (c1 >= c2) << endl;
    cout << "C1 <= C2: " << (c1 <= c2) << endl;
    cout << "C1 > C2: " << (c1 > c2) << endl;
    cout << "C1 < C2: " << (c1 < c2) << endl;

    cout << "++C3 = ";
    Complex result11 = ++c3 ;
    result11.print();

    cout << "--C2 = ";
    Complex result12 = --c1 ;
    result12.print();

    cout << "C2++ = ";
    Complex result13 = c2++ ;
    result13.print();

    cout << "C3 implicit to int: " << (int)c2 << endl;

    return 0;
}
