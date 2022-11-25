#include <iostream>

using namespace std;

int BinarySearch(int * arr ,int Low,int High ,int Value)
{
    if(Low<=High)
    {
        int mid=(Low+High)/2;
        if(Value == arr[mid]) return mid;
        else if (arr[mid]>Value)
        return
        BinarySearch(arr,Low,mid-1,Value);
        else
            BinarySearch(arr,mid+1,High,Value);
    }
    return -1;
}

int main()
{
    cout << "Recursive Binary Search " << endl;
    int arr[8]={1,3,4,5,8,12,20,23};

    cout << BinarySearch(arr,0,7,5);
    return 0;
}
