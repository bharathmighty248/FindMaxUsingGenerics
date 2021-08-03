using System;

namespace MaximumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMax<int> findMaxInt = new FindMax<int>(234, 456, 678);
            findMaxInt.Maximum();
            FindMax<double> findMaxDouble = new FindMax<double>(234.00, 456.00, 678.00);
            findMaxDouble.Maximum();
            FindMax<string> findMaxString = new FindMax<string>("Apple", "Peach", "Banana");
            findMaxString.Maximum();
        }
    }
}
