#include <iostream>

using namespace std;

void Swap(int *a, int *b) {
  int temp = *a;
  *a = *b;
  *b = temp;
}


void BubbleSort(int  arr[],int Size)
{
    for(int i=0;i<Size-1;i++)
    {
        for(int j=0;j<Size-i-1;j++)
        {
            if(arr[j]>arr[j+1])
            {
                Swap(&arr[j],&arr[j+1]);
            }
        }
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
    cout << "Bubble Sort ASC" << endl;

    int arr[] = {64, 25, 12, 22, 11};

    Print(arr);

    cout << endl ;

    BubbleSort(arr,5);
    Print(arr);

    return 0;
}
