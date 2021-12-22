using Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise4;
using Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp
{
    class Oak : Tree2, IFallingLeavesTree, IGrowingRootsTree
    {
        //'there is no argument given that corresponds to required formal parameter'?
        //-> Need an constructor from base class!!!

        public Oak(int nrOfLeaves, int age) : base(nrOfLeaves, age)
        {

        }
        public override bool LeavesAreFalling()
        {
            return true;

        }
        // CS0114, hides base class member  
        // try the following line instead  
        // override public void f()
        //Implement Interface in the parent and child class? I get the warning
        public void LeavesFall()
        {
            Console.WriteLine("Leaves fall every year. ");
        }
        //When it is interface, override is not needed anymore

        public void LeavesGrow()
        {
            Console.WriteLine("Leaves grow green. ");
        }

        public void GrowRoots()
        {
            Console.WriteLine("Grow Roots in the ground ");
        }
    }
}
