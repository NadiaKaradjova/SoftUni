using System;
using System.Linq;

namespace Custom_List
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            var temp = customList.Elements.OrderBy(x => x);
            return new CustomList<T>(temp);
        }
    }
}