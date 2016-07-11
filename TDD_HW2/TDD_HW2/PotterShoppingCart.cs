using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HW2.Extension
{
    public static class PotterShoppingCart//<T, TKey>
    {
        static int singlePrice = 100;

        public static double CaculatePrice<T, TKey>(this IEnumerable<T> books, Func<T, TKey> selector)
        {
            var groups = books.GroupBy(selector);
            var groupsNums = groups.Count();
            var sum = 0.0;

            if (groupsNums == 1)
            {
                var nums = books.Count();
                sum = nums * singlePrice;
            }
            else if (groupsNums == 2)
            {
                //foreach (var g in groups)
                //{
                //    var group1 = books.Intersect(g);
                //}
                sum = singlePrice * 2 * 0.95;
            }
            return sum;
        }
    }

}
