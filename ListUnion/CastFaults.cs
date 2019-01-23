using System;
using System.Collections.Generic;
using System.Drawing;

namespace ListUnion
{
    public class CastFaults : ICloneable
    {
        public int x;
        public CastFaults(int y) { x = y; }
        public Object Clone()
        {
            Object result = new CastFaults(x);
            return result;
        }
    }
    public class Truck : CastFaults
    {
        public int y;
        public Truck(int z) : base(z) { y = z; }
        public new Object Clone()
        {
            Object result = new Truck(y);
            return result;
        }
    }



    public class BigDecimalTest
    {
        public decimal x = new decimal(1.0);
        public decimal y = new decimal(1.00);
        public SortedSet<decimal> decimalTree = new SortedSet<decimal>();
        public HashSet<decimal> decimalHash = new HashSet<decimal>();

        public BigDecimalTest()
        {
            decimalTree.Add(x);
            decimalTree.Add(y);

            decimalHash.Add(x);
            decimalHash.Add(y);
        }

        public void PrintLn()
        {
            Console.WriteLine("DecimalTree = " + decimalTree);
            Console.WriteLine("DecimalHas = " + decimalHash);
            Console.ReadKey();
        }
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
            if (obj.GetType() == typeof(Point)) return (obj.Equals(this));
            if (!(obj.GetType() == typeof(ColorPoint))) return false;
            ColorPoint cp = (ColorPoint)obj;
            return (base.Equals(cp) && (cp.color == color));
        }
    }
}
