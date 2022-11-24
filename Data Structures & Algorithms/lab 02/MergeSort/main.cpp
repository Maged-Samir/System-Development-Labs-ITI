#include <iostream>

using namespace std;

void swapping(int &a, int &b) {     //swap the content of a and b
   int temp;
   temp = a;
   a = b;
   b = temp;
}
void merge(int *array, int l, int m, int r) {
   int i, j, k, nl, nr;
   //size of left and right sub-arrays
   nl = m-l+1; nr = r-m;
   int larr[nl], rarr[nr];
   //fill left and right sub-arrays
   for(i = 0; i<nl; i++)
      larr[i] = array[l+i];
   for(j = 0; j<nr; j++)
      rarr[j] = array[m+1+j];
   i = 0; j = 0; k = l;
   //marge temp arrays to real array
   while(i < nl && j<nr) {
      if(larr[i] <= rarr[j]) {
         array[k] = larr[i];
         i++;
      }else{
         array[k] = rarr[j];
         j++;
      }
      k++;
   }
   while(i<nl)
    {       //extra element in left array
      array[k] = larr[i];
      i++; k++;
   }
   while(j<nr)
   {     //extra element in right array
      array[k] = rarr[j];
      j++; k++;
   }
}

void mergeSort(int *array, int l, int r) {
   int m;
   if(l < r) {
      int m = l+(r-l)/2;
      // Sort first and second arrays
      mergeSort(array, l, m);
      mergeSort(array, m+1, r);
      merge(array, l, m, r);
   }
}


void Print(int * arr)
{
    for(int i=0;i<10;i++)
    {
        cout << arr[i]  << " ";
    }
}


int main()
{

    cout << "Merge Sort" << endl;
    int arr[] = {2,5,6,3,11,4,8,9,12,7};
    Print(arr);

    cout << endl ;


    mergeSort(arr,0,9);
    Print(arr);

    return 0;
}
