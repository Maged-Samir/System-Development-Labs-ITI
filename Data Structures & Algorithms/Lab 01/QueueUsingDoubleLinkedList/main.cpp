#include <stdio.h>
#include <stdlib.h>

typedef struct node
{
    int number;
    struct node *prev;
    struct node *next;
}
node;

node *head;
node *tail;

// Removing element from the queue
int dequeue()
{
    int value;
    value = head->number;

    (head->prev)->next = NULL;
    head = head->prev;

    return value;
}

// Adding node to the queue
void enqueue(int value)
{
    node *n =(node*) malloc(sizeof(node));
    if (n == NULL)
    {
        return;
    }

    n->number = value;
    n->next = NULL;
    n->prev = NULL;

    if (head == NULL && tail == NULL)
    {
        head = n;
        tail = n;
    }
    else
    {
        n->next = tail;
        tail->prev = n;
        tail = n;
    }
}

int main(void)
{


    enqueue(1);
    enqueue(2);
    enqueue(3);



    int x;
    x = dequeue();
    printf(" First Element: %d\n", x);

    x = dequeue();
    printf("Second Element: %d\n", x);


    dequeue();
}
