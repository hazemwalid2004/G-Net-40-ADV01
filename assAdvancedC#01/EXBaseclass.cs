using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assAdvancedC_01
{
    internal class EXBaseclass<T> where T : Person
    {
        public void TryConstraint (T person) 
        {
            Console.WriteLine("success");
        }    
    }
}
