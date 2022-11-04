#include <iostream>

using namespace std;

template<class T>

class intArray
{
    T *arr;
    int Size;

public:
    intArray(int s)
    {
        Size=s;
        arr=new T [Size];
    }

    ~intArray()
    {
        //for(int i=0;i<Size;i++)
            //arr[i]=-1;
            delete[]arr;
    }

    int getSize()
    {
        return Size;
    }

    void SetValue(int index,int value)
    {
        if((index>=0)&&(index<Size))
        {
            arr[index]=value;
        }
    }

    int GetValue(int index)
    {
    if((index>=0)&&(index<Size))
        {
           return arr[index];
        }
    }

    T & operator[](int index)
    {
        if((index>=0)&&(index<Size))
        {
           return arr[index];
        }
    }

};

int main()
{
    cout << "Test Array with Integers ! " << endl;

    intArray <int>myarr(5);
    /*
    myarr.SetValue(0,2);
    myarr.SetValue(1,4);
    myarr.SetValue(2,6);
    myarr.SetValue(3,8);
    myarr.SetValue(4,10);
    */

    myarr[0]=3;
    myarr[1]=5;
    myarr[2]=7;
    myarr[3]=9;
    myarr[4]=11;

    for(int i=0;i<myarr.getSize();i++)
    {
        //cout<<myarr.GetValue(i) << endl;
        cout<<myarr[i] << endl;;
    }

   cout << " ****************************************************** " << endl;

    cout << "Test Array with chars ! " << endl;

    intArray <char>myarr2(5);
    myarr2[0]='m';
    myarr2[1]='a';
    myarr2[2]='g';
    myarr2[3]='e';
    myarr2[4]='d';


    for(int i=0;i<myarr2.getSize();i++)
    {
        //cout<<myarr.GetValue(i) << endl;
        cout<<myarr2[i] << endl;;
    }


    return 0;
}
