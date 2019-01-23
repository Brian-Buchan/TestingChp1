using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListUnion
{
    public class ListJoiner
    {
        public static List<string> Union(List<string> list1, List<string> list2)
        {
            if (list1 != null)
            {
                if (list2 != null)
                {
                    foreach (string s in list2)
                        list1.Add(s);
                    return list1;
                }
                else
                    return list1;
            }
            else if (list2 != null)
                return list2;
            else
                return new List<string>();
        }
    }
}
