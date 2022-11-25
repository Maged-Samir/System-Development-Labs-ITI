#include <iostream>

using namespace std;

int BinarySearch(int* arr ,int Size,int Value)
{
    int low=0,High=Size-1;
    while(High>=low)
    {
       int mid=(low+High)/2;
        if(arr[mid]==Value) return mid;
            else if(arr[mid]>Value)
            High=mid-1;
        else
            low=mid+1;
    }
    return -1;
}


int main()
{
    cout << "Iterative Binary Search" << endl;

    int arr[8]={1,3,4,5,8,12,20,23};

    cout << BinarySearch(arr,8,5);

    return 0;
}
