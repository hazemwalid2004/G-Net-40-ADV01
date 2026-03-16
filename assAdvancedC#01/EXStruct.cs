using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class EXStruct<T> where T : struct
    {
        public T Value { get; set; }
        public EXStruct(T value ) 
        {
            Value = value;
        }
    }
}
