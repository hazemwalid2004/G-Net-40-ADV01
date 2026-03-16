using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class Pair<Tkey, Tvalue>
    {
        public Tkey Key { get; set; }
        public Tvalue Value { get; set; }
    }
}
