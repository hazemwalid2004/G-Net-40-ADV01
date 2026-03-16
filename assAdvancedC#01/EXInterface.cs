using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class EXInterface<T> where T : IComparable<T>
    {
        public T Max(T value1,T value2)
        {
            return value1.CompareTo(value2)>0 ? value1:value2;
        }
    }
}
