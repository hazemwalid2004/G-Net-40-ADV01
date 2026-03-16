using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class Addclass
    {
        public  T Max<T>(T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) > 0 ? value1 : value2;
        }
    }
}
