using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsInRefOutTryCatch
{
    internal class In
    {
       
     
        public void UseIn(in int intangible)
        {
            //intangible = 2;
          
        }

        public void UseInObj( in object intangible)
        {
            Console.WriteLine("Not implemented " + intangible);
        }
    }
}
