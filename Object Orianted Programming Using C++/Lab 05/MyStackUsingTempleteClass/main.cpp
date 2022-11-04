#include <iostream>

using namespace std;

template<class T>

class MyStack
{
    T* stack, top, size;
    public:
    MyStack(int _size)
    {
        top = 0;
        size = _size;
        stack = new T [size];
    }

    ~MyStack()
    {
        delete []stack;
    }

    bool IsFull()
    {
        return top==size;
    }

    bool IsEmpty()
    {
        return top==0;
    }

    int Pop()
    {
        if(!IsEmpty()) return stack[--top];
        else {
            cout << "The stack is empty" << endl;
            return  -1;
        }
    }

    void Push(T n)
    {
        if(!IsFull()) stack[top++] = n;
        else cout << "The stack is full";
    }

    int Peek()
    {
        if(!IsEmpty()) return stack[top-1];
        else {
            cout << "The stack is empty" << endl;
            return  -1;
        }
    }

    int GetCount()
    {
        return size - top - 1;
    }

    void Print()
    {
        for (int i = 0; i < top; ++i) {
            cout << stack[i] << " ";
        }

        cout << endl;
    }
};

int main()
{
    cout << " Stack Of Integers!" << endl;

    MyStack <int> S1(3);
    S1.Push(5);
    S1.Push(2);
    S1.Push(3);

    S1.Print();

    cout << "*****************************" << endl;

    cout << " Stack Of chars!" << endl;

    MyStack <char> S2(3);
    S2.Push('m');
    S2.Push('a');
    S2.Push('g');

    S2.Print();

    return 0;
}
