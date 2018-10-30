using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_3
{
    public partial class Class1
    {
        partial void PartialMethod(int val);

          public void MyPartialClass()
            {
            
            }      

         public void Method2(int val)
            {
                 Console.WriteLine(val);
            }
    }
}
