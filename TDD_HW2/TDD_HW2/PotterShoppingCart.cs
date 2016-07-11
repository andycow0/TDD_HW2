using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HW2.Extension
{
    public static class PotterShoppingCart//<T, TKey>
    {

        public static int CaculatePrice<T, TKey>(this IEnumerable<T> books, Func<T, TKey> selector)
        {
            var groups = books.GroupBy(selector);
            
            return books.Count() * 100;
        }
    }

    //public enum HarryPotter
    //{
    //    First,
    //    Second,
    //    Third,
    //    Fourth,
    //    Fifth,
    //}

}
