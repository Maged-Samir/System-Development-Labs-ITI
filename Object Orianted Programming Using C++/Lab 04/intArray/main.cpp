#include <iostream>

using namespace std;

class intArray
{
    int *arr;
    int Size;

public:
    intArray(int s)
    {
        Size=s;
        arr=new int [Size];
    }

    ~intArray()
    {
        for(int i=0;i<Size;i++)
            arr[i]=-1;
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

    int & operator[](int index)
    {
        if((index>=0)&&(index<Size))
        {
           return arr[index];
        }
    }

};

int main()
{
    cout << "Your Intiger Array ! " << endl;

    intArray myarr(5);
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


    return 0;
}
