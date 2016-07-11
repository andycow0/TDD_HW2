using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HW2
{
    public class PotterShoppingCart<T>
    {

        public int GetPrice(IEnumerable<T> books)
        {
            //var num = books.GroupBy(selector);

            return books.Count() * 100;
        }
    }

    public enum HarryPotter
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth,
    }

}
