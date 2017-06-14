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
            int i;
            int k;
            Tuple<int, int> result = null;
            while (result == null)
            {
                for (i = 0; i < list.Count; i++)
                {
                    for (k = 0; k < list.Count; k++)
                        if (list[i] + list[k] == sum)
                        {
                            result = new Tuple<int, int>(i, k);
                        }
                }
            }
            return result;
        }

    }

}
