using System;

namespace MaximumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding Maximum Int
            int[] intValues = { 234, 456, 678, 890 };
            FindMax<int> findMaxInt = new FindMax<int>(intValues);
            findMaxInt.Maximum(intValues);
            findMaxInt.PrintMax();

            //Finding Maximum Float
            double[] doubleValues = { 234.00, 456.00, 678.00, 890.00 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleValues);
            findMaxDouble.Maximum(doubleValues);
            findMaxDouble.PrintMax();

            //Finding Maximum String
            string[] stringValues = { "Peach", "Apple", "Banana", "Mango" };
            FindMax<string> findMaxString = new FindMax<string>(stringValues);
            findMaxString.Maximum(stringValues);
            findMaxString.PrintMax();
        }
    }
}
