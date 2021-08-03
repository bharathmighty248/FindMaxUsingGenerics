using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumValue
{
    public class FindMax
    {
        /// <summary>
        /// Generic Method for finding Maximum value Int Or Float Or String 
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        /// <returns></returns>
        public T Maximum<T>(T firstValue, T secondValue, T thirdValue) where T: IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                return thirdValue;
            throw new Exception("3 values are Equal");
        }


    }
}
