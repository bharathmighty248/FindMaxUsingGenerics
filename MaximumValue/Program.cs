using System;

namespace MaximumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMax findMax = new FindMax();
            findMax.Maximum(234, 456, 678);
            findMax.Maximum(234.00, 456.00, 678.00);
            findMax.Maximum("Peach", "Apple", "Banana");
        }
    }
}
