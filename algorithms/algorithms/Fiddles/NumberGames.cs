using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.Fiddles
{
    class NumberGames
    {
        public static void Demo()
        {
            
        }

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            //var items = list.Select((value, index) => new {index, value});

            var hits = 
                from a in list
                from b in list
                where (a + b == sum && a)
                select new Tuple<int,int>( a.index, b.index);

            return hits.FirstOrDefault();
        }

 /*       public static Tuple<int, int> FindTwoEqualsSum(IList<int> list, int sum)
        {
            int i;
            int k;
            Tuple<int, int> result = null;
            for (i = 0; i < list.Count; i++)
            {
                for (k = i + 1; k < list.Count; k++)
                    if (list[i] + list[k] == sum)
                    {
                        result = new Tuple<int, int>(i, k);
                        return result;
                    }
            }
            return result;
        }

    } */

}
