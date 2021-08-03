using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumValue
{
    public class FindMax<T> where T: IComparable
    {
        /// <summary>
        /// Generic Class for finding Maximum value Int Or Float Or String (With Constructor)
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        /// <returns></returns>
        public T firstValue, secondValue, thirdValue;
        public FindMax(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public T Maximum()
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
