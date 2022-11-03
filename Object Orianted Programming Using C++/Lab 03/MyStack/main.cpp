#include <iostream>

using namespace std;

class MyStack{
    int *stk;
    int tos;
    int Size;

public:
    //Ctor
    MyStack(int l)
    {
        tos = 0;
        Size = l;
        stk = new int[l];
    }
    //Copy Constractour
    /*
    MyStack(const MyStack &s)
    {
        tos=s.tos;
        Size=s.Size;
        stk=new int [Size];
        for(int i=0;i<tos;i++)
        {
            stk[i]=s.stk[Size];
        }
    }
    */

    bool isEmpty(){return tos == 0;}

    bool isFull(){return tos == Size;}

    void push(int num){
        if(!isFull()){
            stk[tos++] = num;
            cout<<endl<<"Number "<< num << " Pushed successfully."<<endl;
        }
        else
            cout<<endl<<"The stack is Full cann`t push "<<num<<endl;
    }

    int pop(){
        if(!isEmpty())
            cout<< "pop element "<<stk[--tos]<<" from the stack"<<endl;
        else
            cout<<"The stack is Empty"<<endl;
    }

    int peek() {
         int temp = stk[--tos];
         tos++;
         return temp;
    }


    int GetCount(){
        return tos;
    }
    //Reverse


    //Destructor
    ~MyStack(){
        delete []stk;
    }
  friend void viewContent(MyStack);


    MyStack reverseStack()
    {
        MyStack reversed = MyStack(GetCount());

        for (int i = GetCount(); i >= 0; i--)
        {
            reversed.push(i);
        }

        return reversed;
    }

};


void viewContent(MyStack stk)
{
    for (int i = stk.GetCount(); i >0; i--)
    {
        cout << i << "- " << stk.pop()<< endl;
    }
}




//Function to print stars
void printStars(){
        cout<<endl<<"**************************"<<endl;
}

int main()
{
    int Size;
    cout<<"Enter the size of stack: ";
    cin>>Size;

    MyStack  s1(Size);
    int choice, exitFlag = 0, number;


    do{
        cout<<endl<<"Choose operation( 1-Push 2-pop 3-peek 4-Length_of_stack  5-Exit 6-ViewContent 7-)"<<endl;
        cin>>choice;

        switch(choice){
        case 1:
            cout<<"Enter a number: ";
            cin>>number;
            s1.push(number);
            printStars();
            break;

        case 2:
            s1.pop();
            printStars();
            break;
        case 3:
            cout<<"current Element "<<s1.peek();
            printStars();
            break;
        case 4:
            cout<<"The length of stack is "<<s1.GetCount();
            printStars();

            break;
        case 5:
            exitFlag = 1;
            break;
        case 6:
            //ViewContent
             viewContent(s1);
            break;
        case 7:
            //Reverse Stack
            cout << "first element in the reversed stack: " << s1.reverseStack().peek() << endl;


            break;
        default:
            cout<<"Wrong operation Try again"<<endl;
            printStars();
            }

    }while(!exitFlag);

    return 0;
}
