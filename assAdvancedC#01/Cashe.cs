using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class Cashe<Tkey,Tvalue>
    {
        public Tkey Key { get; set; }
        public Tvalue Value { get; set; }
        public void Remove ()
        {
            Key = default;
            Value = default;
        }
        public void Contain()
        {
            Console.WriteLine("Contain");
        }

    }
}
