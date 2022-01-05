using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session5RequirementsSolved.RequirementsAndSolutions
{
    partial class ChildForest: Forest
    {
         public void Call()
        {
            PrintAllInstanceHeight();
        }
    }

    partial class ChildForest
    {
        public void noInheritance()
        {
            PrintAllInstanceHeight();
        }
    }
}
