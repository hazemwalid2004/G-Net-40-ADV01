using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class EXNew<T> where T : new()
    {
        public T create() 
        {
            return new T();
        }
    }
    public class A
    {
        public int value { get; set; }
    }
}
