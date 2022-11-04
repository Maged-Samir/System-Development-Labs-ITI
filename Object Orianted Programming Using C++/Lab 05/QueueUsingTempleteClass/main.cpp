#include <iostream>
using namespace std;

template <class T>

class MyQueue
{
    T queue[100],
    n = 100,
    front = - 1,
    rear = - 1;
public:
void Insert()
{
   T val;
   if (rear == n - 1)
   cout<<"Queue Overflow"<<endl;
   else {
      if (front == - 1)
      front = 0;
      cout<<"Insert the element in queue : "<<endl;
      cin>>val;
      rear++;
      queue[rear] = val;
   }
}

void Delete()
 {
   if (front == - 1 || front > rear) {
      cout<<"Queue Underflow ";
      return ;
   } else {
      cout<<"Element deleted from queue is : "<< queue[front] <<endl;
      front++;;
   }
}
void Display()
{
   if (front == - 1)
   cout<<"Queue is empty"<<endl;
   else {
      cout<<"Queue elements are : ";
      for (int i = front; i <= rear; i++)
      cout<<queue[i]<<" ";
         cout<<endl;
   }
}

};


int main() {

cout << "Enter your Integer elements" << endl;
MyQueue <int> q ;
q.Insert();
q.Insert();
q.Insert();

q.Display();

cout << "********************************************************" << endl;

cout << "Enter your Char elements" << endl;
MyQueue <char> q1 ;
q1.Insert();
q1.Insert();
q1.Insert();

q1.Display();

   return 0;
}



