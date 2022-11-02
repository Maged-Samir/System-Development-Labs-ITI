#include <iostream>

using namespace std;

class MyStack{
    int *stk;
    int tos;
    int Size;

public:
    //Ctors
    MyStack(int l){
        tos = 0;
        Size = l;
        stk = new int[l];
    }

    bool isEmpty(){return tos == 0;}

    bool isFull(){return tos == Size;}

    void push(int num)
    {
        if(!isFull()){
            stk[tos++] = num;
            cout<<endl<<"Number "<< num << " Pushed successfully."<<endl;
        }
        else
            cout<<endl<<"The stack is Full cann`t push "<<num<<endl;
    }

    int pop()
    {
        if(!isEmpty())
            cout<< "pop element "<<stk[--tos]<<" from the stack"<<endl;
        else
            cout<<"The stack is Empty"<<endl;
    }

    int peek()
    {
         int temp = stk[--tos];
         tos++;
         return temp;
    }


    int GetCount()
    {
        return tos;
    }

    //Destructor
    ~MyStack(){
        delete []stk;
    }

};

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
        cout<<endl<<"Choose operation( 1-Push  2-pop  3-peek  4-Length_of_stack  5-Exit)"<<endl;
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
        default:
            cout<<"Wrong operation Try again"<<endl;
            printStars();
            }

    }while(!exitFlag);

    return 0;
}
