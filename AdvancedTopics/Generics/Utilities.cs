using System;

namespace AdvancedTopics
{
    //Different types of constraints:
    //where T : IComparable
    //where T : Product (which means T Is a class e.g. Product)
    //where T : struct (which means value type)
    //where T : class (which means reference type)
    //where T : new() (which means T is an object that has a default contructor)
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class DiscountCalculator<T> where T : Product
    {

    }
}
