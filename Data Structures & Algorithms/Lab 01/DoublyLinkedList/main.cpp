#include <iostream>
#include <stdlib.h>

using namespace std;


 class Node
{
    public:
    int Data;
    Node* Pnext;
    Node* Pprev;
};

Node * Pstart;
Node * Plast;

Node * NewNode (int D)
{
    Node * Pnew = new Node();
    if(Pnew == NULL) exit(0);
    Pnew ->Data=D;
    Pnew ->Pnext=NULL;
    Pnew ->Pprev=NULL;
    return Pnew;
}

void AddNode(int Key)
{
  Node * Pnew=NewNode(Key);
  if(Plast == NULL)
    Plast=Pstart=Pnew;
  else
    Plast ->Pnext=Pnew;
    Pnew ->Pprev=Plast;
    Plast=Pnew;
}

Node * SearchList(int Key)
{
    Node * Psearch =Pstart;

    while(Psearch != NULL)
    {
        if(Psearch ->Data==Key)
            break;
        Psearch=Psearch->Pnext;

    }

    return Psearch;

}

void Display(int Key)
{
    Node * Pdisplay=SearchList(Key);
    if(Pdisplay == NULL)
        cout << "Not Found" << endl ;
    else
    {
        cout << Pdisplay->Data  << endl;
    }
}

void DisplayAll()
{
    Node * Pdisplay=Pstart;
    while(Pdisplay != NULL)
    {
        cout << Pdisplay->Data << endl ;
        Pdisplay=Pdisplay->Pnext;
    }
}

void Delete(int Key)
{
    Node * Pdelete=SearchList(Key);
    if(Pdelete == NULL)
    {
        cout << "Not Found " << endl ;
    }
    else
    {
        if(Pstart==Plast)
        {
            Pstart=Plast=NULL;
        }
        else if (Pstart == Pdelete)
        {
            Pstart=Pstart->Pnext;
            Pstart->Pprev=NULL;
        }
        else if (Plast == Pdelete)
        {
            Plast=Plast->Pprev;
            Plast->Pnext=NULL;
        }
        else
        {
            Pdelete->Pprev->Pnext=Pdelete->Pnext;
            Pdelete->Pnext->Pprev=Pdelete->Pprev;
        }
        delete Pdelete;
    }

}

void DeleteAll()
{
    Node * pTemp;
    while(Pstart !=NULL)
    {
        pTemp=Pstart;
        Pstart=Pstart->Pnext;
        delete pTemp;
    }
    Plast = NULL;
    cout << "ALL Elements Deeleted Succefully !" ;
}

void InsertNode(int Data)
{
    Node * pnew =NewNode(Data);
    if(Pstart ==NULL)
        Pstart=Plast=pnew;
    else
    {
        Node * Psearch=Pstart;
        while((Psearch !=NULL)&& (Psearch->Data)<Data)
        Psearch=Psearch->Pnext;
        if(Psearch ==NULL)
        {
            Plast->Pnext=pnew;
            pnew->Pprev=Plast;
            Plast=pnew;
        }
        else if(Psearch == Pstart)
        {
            Pstart->Pprev=pnew;
            pnew->Pnext=Pstart;
            Pstart=pnew;
        }


    }

}

int main()
{
    cout << "Doubly linked List !" << endl;

   // AddNode(2);
   // AddNode(5);
   //AddNode(3);

    //Display(0);
    //Display(2);
    //Display(5);

    //Delete(5);
    //DeleteAll();

/*
    InsertNode(7);
    InsertNode(5);
    InsertNode(3);
    InsertNode(2);
    InsertNode(9);
    InsertNode(20);
*/

    DisplayAll();

    return 0;
}
