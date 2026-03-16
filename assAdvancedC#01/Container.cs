using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class Container<T>
    {
        T[] values=new T[10];
        public T ContainerId { get;  }
        public void Add (T containerId)
        {
            for (int i = 0; i < values.Length; i++) 
            {
                if (values[i]==null)
                values [i] = containerId;
            }
        }
    }
}
