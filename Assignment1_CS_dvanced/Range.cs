using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_CS_dvanced
{
    internal class Range<T>:IComparable<T>
    {
        public T MaxRange {  get; set; }
        public T MinRange { get; set; }

        public Range(T max ,T min)
        {
            MaxRange = max;
            MinRange = min;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(MinRange) >= 0 && value.CompareTo(MaxRange) <= 0;
        }


       
        public double? GetRangeLength()
        {
            if (typeof(T) == typeof(int) ||
                typeof(T) == typeof(double) ||
                typeof(T) == typeof(float) ||
                typeof(T) == typeof(decimal))
            {
                dynamic min = MinRange;
                dynamic max = MaxRange;
                return max - min;
            }
            return null; // Length not applicable for non-numeric types
        }
        public override string ToString()
        {
            return $"Range: [{MinRange}, {MaxRange}]";
        }

       
    }
}
