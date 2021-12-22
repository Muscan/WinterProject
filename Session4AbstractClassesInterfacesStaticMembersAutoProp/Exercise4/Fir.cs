using Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise4
{
    class Fir : Tree2, IGrowingRootsTree
    {
        public Fir(int nrOfLeaves, int age) : base(nrOfLeaves, age)
        {

        }
        public override bool LeavesAreFalling()
        {
            return false;
        }
        public void GrowRoots()
        {
            Console.WriteLine("Only grow Roots fir Fir ");
        }
    }
}
