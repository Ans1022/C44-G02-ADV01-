using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point : IComparable<Point>
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return ($"{x} , {y}");
        }

        //public int CompareTo(object? Obj)
        //{
        //    Point p = (Point)Obj;
        //    if (x == p.x)return y.CompareTo(p.y);
        //    return x.CompareTo(p.x);

        //}

        //public int CompareTo(object? Obj)
        //{
        //    if ( Obj  is not null ) 
        //    {
        //          Point p = (Point)Obj;
        //    if (x == p.x) return y.CompareTo(p.y);
        //    return x.CompareTo(p.x);

        //    }
        //    return 1;
        //}



        //public int CompareTo(object? Obj)
        //{ 
        //    // 1. Is Conditional Opreater
        //    if (Obj is not null)
        //    {
        //        if(Obj is Point) 
        //        { 
        //           Point p = (Point)Obj;
        //           if (x == p.x) return y.CompareTo(p.y);
        //           return x.CompareTo(p.x);
        //        }
        //    }
        //    return 1;
        //}


        //public int CompareTo(object? Obj)
        //{
        //    // 1. as Conditional Opreater
            
        //        Point p = Obj as Point;
        //    if (p != null)
        //    {
        //        if(x == p.x) return y.CompareTo(p.y);
        //        return x.CompareTo(p.x);
        //    }
            
        //    return 1;
        //}

        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                if (x == other.x) return y.CompareTo(other.y);
                return x.CompareTo(other.x);
            }
            return 1;
        }
    }
}
    
    



