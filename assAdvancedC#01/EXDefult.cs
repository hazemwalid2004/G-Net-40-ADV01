using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class EXDefult<T>
    {
        T Value { get; set; }
        private bool hasValue;
        public T SafeList()
        {
            return hasValue ? Value : default;
        }
    }
}
