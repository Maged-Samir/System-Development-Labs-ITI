using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_05
{
    internal class Point3D
    {
        public int x { get; set; }
        public int y { get; set; }

        public int z { get; set; }

        public Point3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Point3D(int x)
        {
            this.x = x;
        }

        public Point3D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {

            return $"Your Point Is :({x},{y},{z})";

        }

        public override bool Equals(object obj)
        {
            Point3D p = (Point3D)obj;
            return (p.x == x && p.y == y && p.z == z);
        }

        public static bool Equality(Point3D p1, Point3D p2)
        {
            if(p1.x==p2.x&&p1.y==p2.y&&p1.z==p2.z) 
                return true;
            else return false;
        }


    }
}
