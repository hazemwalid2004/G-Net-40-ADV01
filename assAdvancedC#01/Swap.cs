using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class Swap
    {
        public void swap<T>(ref T value1,ref T value2)
        {
            T temp= value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
