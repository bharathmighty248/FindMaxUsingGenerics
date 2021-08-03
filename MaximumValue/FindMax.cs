using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumValue
{
    public class FindMax<T> where T: IComparable
    {
        /// <summary>
        /// Generic Class for finding Maximum value Int Or Float Or String (With Constructor)
        /// Array is for Taking Morethan 3 Parameters
        /// </summary> 
        public T[] value;
        public FindMax(T[] value)
        {
            this.value = value;
        }

        /// <summary>
        /// First Sort the given Array of Values
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        /// <summary>
        /// Maximum Method to Find Maximim Value
        /// </summary>
        public T Maximum(T[] values)
        {
            var maxValue = Sort(values);
            return maxValue[^1];    //^1 is the first Index from End, So it gives sorted Max Value from End of Array
        }


    }
}
