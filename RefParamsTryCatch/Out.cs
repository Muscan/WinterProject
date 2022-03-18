using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsInRefOutTryCatch
{
    internal class Out
    {
        public void UseOut(out string name, out int age)
        {
            name = "John";
            age = 10;
            
        }
    }
}
