using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> NamesA = new List<string>();
            List<string> NamesB = new List<string>();
            NamesA.Add("Bob");
            NamesA.Add("Bill");
            NamesA.Add("Rick");
            NamesA.Add("Joe");
            NamesB.Add("Ray");
            NamesB.Add("Julie");
            NamesB.Add("Amy");
            NamesB.Add("Mike");

            Console.Write("List1: ");
            PrintList(NamesA);

            Console.Write("\nList2: ");
            PrintList(NamesB);

            Console.Write("\nCombining both lists...press any key to continue.");
            Console.ReadKey();

            Console.Write("\nCombined List: ");
            PrintList(ListJoiner.Union(NamesA, NamesB));

            Console.Write("\nThank you!");
            Console.ReadKey();

            //Console.Clear();
            //Console.WriteLine("Check for Decimal Tests follows: press any key to continue...");
            //Console.ReadKey();
            //BigDecimalTest BDT = new BigDecimalTest();
            //BDT.PrintLn();
            //Console.ReadKey();
        }

        static void PrintList(List<string> list)
        {
            foreach (string s in list)
            {
                Console.Write(s + ", ");
            }
        }

    }
}
