#include <stdio.h>
#define MAX 5


int main () {

   int  var[] = {10,20,30,40,50};
   int i, *ptr[MAX];

   for ( i = 0; i < MAX; i++) {
      ptr[i] = &var[i];
   }

   for ( i = 0; i < MAX; i++) {
      printf("Values of Element[%d] = %d\n", i, *ptr[i] );
   }

   return 0;
}
