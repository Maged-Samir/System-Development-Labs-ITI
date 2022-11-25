#include <iostream>

using namespace std;

int SearchSortedAlgorithm(int* arr,int Size ,int Value)
{
    for(int i=0;i<Size;i++)
        if (arr[i]== Value)
            return i;
            return -1;
}

int main()
{
    cout << "Hello world!" << endl;
    int arr[5]={3,5,6,8,10};
   cout<<  SearchSortedAlgorithm(arr,6,5);

    return 0;
}
