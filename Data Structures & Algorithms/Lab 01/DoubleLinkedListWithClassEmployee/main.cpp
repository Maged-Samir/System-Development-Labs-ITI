#include <iostream>
#include <stdlib.h>

using namespace std;

class employee
{
    public:
	int   emp_number;
	char  emp_name[20];
	float emp_basic;
	float emp_da;
	float emp_it;
	float emp_net_sal;

	employee(){}

    employee(int number,char name[20],float basic,float da,float it , float net)
    {
        emp_number=number;
        emp_name[20]=name[20];
        emp_basic=basic;
        emp_da=da;
        emp_it=it;
        emp_net_sal=net;
    }

		void get_emp_details();
		float find_net_salary(float basic, float da, float it);
		void show_emp_details();
};

void employee :: get_emp_details()
{
	cout<<"\nEnter employee number: ";
	cin>>emp_number;
	cout<<"\nEnter employee name: ";
	cin>>emp_name;
	cout<<"\nEnter employee basic: ";
	cin>>emp_basic;
	cout<<"\nEnter employee DA: ";
	cin>>emp_da;
	cout<<"\nEnter employee IT: ";
	cin>>emp_it;
}

float employee :: find_net_salary(float basic, float da, float it)
{
    return (basic+da)-it;
}

void employee :: show_emp_details()
{
	cout<<"\n\n**** Details of  Employee ****";
	cout<<"\nEmployee Name      :  "<<emp_name;
	cout<<"\nEmployee number    :  "<<emp_number;
	cout<<"\nBasic salary       :  "<<emp_basic;
	cout<<"\nEmployee DA        :  "<<emp_da;
	cout<<"\nIncome Tax         :  "<<emp_it;
	cout<<"\nNet Salary         :  "<<find_net_salary(emp_basic, emp_da, emp_it);
	cout<<"\n-------------------------------\n\n";
}

 class Node
{
    public:
    employee Data;
    Node* Pnext;
    Node* Pprev;
};

Node * Pstart;
Node * Plast;

Node * NewNode (employee D)
{
    Node * Pnew = new Node();
    if(Pnew == NULL) exit(0);
    Pnew ->Data=D;
    Pnew ->Pnext=NULL;
    Pnew ->Pprev=NULL;
    return Pnew;
}

void AddNode(employee Key)
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
        if(Psearch ->Data.emp_number==Key)
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
        Pdisplay->Data.show_emp_details();
        //cout << Pdisplay->Data.show_emp_details()  << endl;
    }
}

void DisplayAll()
{
    Node * Pdisplay=Pstart;
    while(Pdisplay != NULL)
    {
        //cout << Pdisplay->Data.show_emp_details() << endl ;
        Pdisplay->Data.show_emp_details();
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

void InsertNode(employee Data)
{
    Node * pnew =NewNode(Data);
    if(Pstart ==NULL)
        Pstart=Plast=pnew;
    else
    {
        Node * Psearch=Pstart;
        while((Psearch !=NULL)&& (Psearch->Data.emp_number)<Data.emp_number)
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

    //DisplayAll();

   //employee emp(1,"maged samir",100,20,20,50);

   employee emp;
   emp.get_emp_details();
   AddNode(emp);

   //DisplayAll();
   // DeleteAll();
   Display(emp.emp_number);

    //emp.get_emp_details();
    //emp.show_emp_details();

    return 0;
}
