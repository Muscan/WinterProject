using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsInRefOutTryCatch
{
    internal class Ref
    {
        //ref uses its reference. /
        //Changes made in the metod, remain also after the call to the method
        public void RefMethod(ref int refArgument)
        {
            refArgument = refArgument + 44;
        }

        public void Method(int argument)
        {
            argument = argument + 44;
        }
         // Output: value from main
    }
}
