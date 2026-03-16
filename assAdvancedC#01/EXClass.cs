using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class EXClass<T> where T : class
    {
        public T Value { get; set; }
        public EXClass(T value )
        {
            Value = value;
        }
    }
}
