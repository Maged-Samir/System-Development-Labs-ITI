#include <iostream>
#include <cstdlib>
#include <stdio.h>


struct Node {
    int data;
    struct Node* prev;
    struct Node* next;
};
Node* start = NULL;
Node* top = NULL;

// Check if stack is empty
bool isEmpty()
{
    if (start == NULL)
        return true;
    return false;
}

// pushes element onto stack
void push(int d)
{
    struct Node* n;
    n = new Node();
    n->data = d;
    if (isEmpty()) {
        n->prev = NULL;
        n->next = NULL;

        // As it is first node if stack
        // is empty
        start = n;
        top = n;
    }
    else {
        top->next = n;
        n->next = NULL;
        n->prev = top;
        top = n;
    }
}

// Pops top element from stack
void pop()
{
    struct Node* n;
    n = top;
    if (isEmpty())
        printf("Stack is empty");
    else if (top == start) {
        top = NULL;
        start = NULL;
        free(n);
    }
    else {
        top->prev->next = NULL;
        top = n->prev;
        free(n);
    }
}

// Prints top element of the stack
void topelement()
{
    if (isEmpty())
        printf("Stack is empty");
    else
        printf(
            "The element at top of the stack is : %d   \n",
            top->data);
}

// Determines the size of the stack
void stacksize()
{
    int c = 0;
    if (isEmpty())
        printf("Stack is empty");
    else {
        struct Node* ptr = start;
        while (ptr != NULL) {
            c++;
            ptr = ptr->next;
        }
    }
    printf("Size of the stack is : %d \n ", c);
}

// Determines the size of the stack
void printstack()
{
    if (isEmpty())
        printf("Stack is empty");
    else {
        struct Node* ptr = start;
        printf("Stack is :  ");
        while (ptr != NULL) {
            printf("%d   ", ptr->data);
            ptr = ptr->next;
        }
        printf("\n");
    }
}

// Driver code
int main()
{
    printf("\n Our Elements in Stack \n");
    push(2);
    push(5);
    push(10);
    printstack();

    pop();




    return 0;
}
