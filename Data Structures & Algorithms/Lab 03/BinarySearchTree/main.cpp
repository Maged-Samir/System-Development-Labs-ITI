#include <iostream>
#include <stdlib.h>

using namespace std;

class Node
{
    public:
    int Key;
    Node* pLeft;
    Node* pRight;
};
Node * pTree=NULL;



Node* SearchTree(Node* pRoot,int Key)
{
    if(pRoot !=NULL)
    {
        if(pRoot->Key==Key)
            return pRoot;
        else if (pRoot->Key >Key)   //go left Sub Tree
            return SearchTree(pRoot->pLeft,Key);
        else                       //go to right Sub Tree
            return SearchTree(pRoot->pRight,Key);
    }
    return NULL; //empty tree
}

Node * NewNode()
{
    Node* pNew=new Node();
    if(pNew == NULL) exit(0);
    pNew->pLeft=pNew->pRight=NULL;
    cout << " Enter New Key \n" ;
    cin >>  pNew->Key;
    return pNew;
}

void InsertNode(Node* & pRoot,Node * pNew)
{
    if(pRoot == NULL)

        pRoot=pNew;
        else if(pRoot->Key >pNew->Key)
            InsertNode(pRoot->pLeft,pNew);
        else
            InsertNode(pRoot->pRight,pNew);

}

void InsertNode(Node*pRoot,Node*pLeaf,Node*pNew)
{
   if(pLeaf == NULL)
   {
       if(pRoot==NULL)

        pTree=pNew;

       else
       {
           if(pRoot->Key >pNew->Key)
            pRoot->pLeft=pNew;
           else
            pRoot->pRight=pNew;
       }

   }
   else if (pNew->Key<pLeaf->Key)
    InsertNode(pLeaf,pLeaf->pLeft,pNew);
   else
    InsertNode(pLeaf,pLeaf->pRight,pNew);
}

int CountNodes(Node * pRoot)
{
    if(pRoot !=NULL)
    {
        return CountNodes(pRoot->pLeft)+1+CountNodes(pRoot->pRight);
    }
    return 0; //empty
}

void TreeTraverse(Node* pRoot)
{
    if(pRoot != NULL)
{
     TreeTraverse(pRoot->pLeft);
    cout<<pRoot->Key  <<endl;
    TreeTraverse(pRoot->pRight);
}
}

int GetMax(Node * pRoot)
{
    while(pRoot->pRight !=NULL)
        pRoot=pRoot->pRight;
    return pRoot->Key;
}
void Delete(Node* &pRoot,int key);
void DeleteNode(Node * &pRoot)
{
    Node* pdelete=pRoot;
    if(pRoot->pLeft==NULL)
    {
        pRoot=pRoot->pRight;
        delete pdelete;
    }
    else if(pRoot->pRight==NULL)
    {
        pRoot=pRoot->pLeft;
        delete pdelete;
    }
    else
    {
        int TempKey=GetMax(pRoot->pLeft);
        pRoot->Key=TempKey;
        Delete(pRoot->pLeft,TempKey);
    }

}

void Delete(Node* &pRoot,int key)
{
    if(key<pRoot->Key)
    Delete(pRoot->pLeft,key);
    else if (key > pRoot->Key)
    Delete(pRoot->pRight,key);
    else
        DeleteNode(pRoot);

}


int main()
{
    cout << " Binary Search Tree " << endl;

    for(int i=0;i<4;i++)
    InsertNode(pTree,NewNode());
    //InsertNode(pTree,pTree,NewNode());


    //Delete(pTree,3);

    Node * psearch=SearchTree(pTree,3);

    if(psearch != NULL)
        cout << " Search Result : Found \n";
    else
        cout << " Search Result : Not Found \n";


    cout << "Numbers Of Nodes in Our Tree ----> " << CountNodes(pTree) <<endl;

    TreeTraverse(pTree);

    return 0;
}
