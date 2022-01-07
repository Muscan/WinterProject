using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session5RequirementsSolved.RequirementsAndSolutions
{
    partial class ChildForest: Forest
    {

        public virtual void noInheritance()
        {
            PrintAllInstanceHeight();
            PrintMessage();
        }

        public void Call()
        {
            PrintAllInstanceHeight();
            PrintMessage();

        }

        public override void PrintMessage()
        {
            Console.WriteLine("Before base.print message");
            base.PrintMessage();
            Console.WriteLine("After base.print message");
        }
    }

    partial class ChildForest 
    {
        
    }
}
