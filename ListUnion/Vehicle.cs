using System;
using System.Collections.Generic;
using System.Drawing;

namespace ListUnion
{
    public class Vehicle : ICloneable
    {
        public int x;
        public Vehicle(int y) { x = y; }
        public Object Clone()
        {
            Object result = new Vehicle(x);
            return result;
        }
    }
    public class Truck : Vehicle
    {
        public int y;
        public Truck(int z) : base(z) { y = z; }
        public new Truck Clone()
        {
            Truck result = Clone();
            result.y = y;
            return result;
        }
    }



    public class BigDecimalTest
    {
        decimal x = new decimal(1.0);
        decimal y = new decimal(1.00);

        //SortedSet<decimal> decimalTree = new SortedSet<decimal>();
        //decimalTree.Add(x);
        //decimalTree.Add(y);

        //HashSet<decimal> decimalHash = new HashSet<decimal>();
        //decimalHash.add(x);
        //decimalHash.add(y);
    }


    public class Point
    {
        private int x;
        private int y;
        public Point(int x, int y) { this.x = x; this.y = y; }

        public override bool Equals(object obj)
        {
            if (!(obj.GetType() == typeof(Point)))
            {
                Point P = (Point)obj;
                return (P.x == x) && (P.y == y);
            }
            return false;
        }
    }
    public class ColorPoint : Point
    {
        private Color color;

        public ColorPoint(int x, int y, Color color) : base(x, y)
        {
            this.color = color;
        }

        public override bool Equals(object obj)
        {
            if (!(obj.GetType() == typeof(ColorPoint))) return false;
            ColorPoint cp = (ColorPoint)obj;
            return (base.Equals(cp) && (cp.color == this.color));
        }
    }
}
