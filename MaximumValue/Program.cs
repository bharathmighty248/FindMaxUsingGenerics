using System;

namespace MaximumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMax findMax = new FindMax();
            findMax.MaximumInt(234, 456, 678);
            findMax.MaximumFloat(234.00, 456.00, 678.00);
            findMax.MaximumString("Peach", "Apple", "Banana");
        }
    }
}
