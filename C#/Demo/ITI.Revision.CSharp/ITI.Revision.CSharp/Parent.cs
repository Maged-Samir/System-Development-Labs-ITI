using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.CSharp
{
    // Inheritance 
    internal class Parent
    {
        public int x { get; set; }
        public Parent(int x)
        {
            this.x = x;
        }

        public virtual void show()
        {
            Console.WriteLine($"x={x}  this method from parent");
        }
    }

    class Child : Parent
    {
        public int y { get; set; }
        public Child(int x, int y) : base(x)
        {
            this.y = y;
        }

        public override void show()
        {
            Console.WriteLine($"x={x},{y}  this method from child");
        } 
    }

    class SubChild: Child
    {
        public int z { get; set; }
        public SubChild(int x,int y,int z):base(x,y)
        {
            this.z = z;
        }

        public override void show() 
        {
            Console.WriteLine($"x={x},{y},{z}  this method from Subchild");
        }
    }

    //Abstraction

    abstract class A
    {
        public abstract void show();
        public abstract void showV2();
    }

    abstract class B : A
    {
        public override void showV2()
        {
            throw new NotImplementedException();
        }
    }

    class C : B
    {
        public override void show()
        {
            throw new NotImplementedException();
        }

        
    }


}
