using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_3
{
     public partial class Class1
    {
        public void Method1(int val)
        {
            Console.WriteLine(val);
        }

        partial void PartialMethod(int val)
        {
            Console.WriteLine(val);
        }
    }
}
