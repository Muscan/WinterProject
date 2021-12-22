using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp
{
    //Class 'class' cannot have multiple base classes:
    class HybridTree : Oak//, Fir - Cannot have multiple classes
    {
        public HybridTree(int nrOfLeaves, int age) : base(nrOfLeaves, age)
        {
            //How does the HybridTree class from which base class should take it`s constructor???
            //This is why we can use as many as we can Interfaces:
            //-they have only Methods with no Implementation, constructor. 

        }
    }
}
