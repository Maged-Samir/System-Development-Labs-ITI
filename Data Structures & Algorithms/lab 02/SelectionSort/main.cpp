#include <iostream>

using namespace std;


int IndexOfMinValue (int* arr ,int StartIndex,int EndIndex)
{
int Index=StartIndex;
for(int i=StartIndex+1;i<EndIndex;i++)
    if(arr[i]<arr[Index])
    Index=i;
return Index;
}

void Swap(int *a, int *b) {
  int temp = *a;
  *a = *b;
  *b = temp;
}


void SelectionSort(int * arr,int Size)
{
    int index;
    for(int i=0;i<Size;i++)
    {
        index=IndexOfMinValue(arr,i,Size);


        Swap(&arr[i],&arr[index]);
    }
}

void Print(int * arr)
{
    for(int i=0;i<5;i++)
    {
        cout << arr[i]  << " ";
    }
}


int main()
{

    cout << "Selection Sort" << endl;

    int arr[] = {64, 25, 12, 22, 11};
    Print(arr);

    cout << endl ;

    SelectionSort(arr,5);
    Print(arr);

    return 0;
}
