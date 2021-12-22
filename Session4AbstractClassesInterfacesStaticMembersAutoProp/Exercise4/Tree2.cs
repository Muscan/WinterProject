using Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise4
{
    abstract class Tree2 : IFallingLeavesTree, IGrowingRootsTree
    {
        //HAVING AUTOS -> 12  are not required
        //private int NrOfLeaves;
        //explicit atributes age 26-29 with Property A
        private int age;

        public Tree2(int NrOfLeaves, int Age)
        {
            //Constructor with Auto generated properties
            this.NrOfLeaves = NrOfLeaves;
            this.age = Age;
        }

        //prop + tab 2times

        public int NrOfLeaves { get; set; } //private int nrOfLeaves; + set+get pt NbOfLeaves
        public int Age
        {
            get { return age; }
            set { age = value; } //public void setAge(int age) { this.age = age;} //classic setter
            //private set { age = value; }
        }
        //properties are public to be able to access them from everywhere, otherwise I will use atributes
        public int InstanceHeight { get; set; }
        public static int StaticHeight { get; set; }


        //Exercise4
        //If a method is abstract in a class, the class need also to be abstract
        public abstract bool LeavesAreFalling();


        public void LeavesFall()
        {
            Console.WriteLine("Tree2 Leaves fall every year. ");
        }
        //When it is interface, override is not needed anymore

        public void LeavesGrow()
        {
            Console.WriteLine("Tree 2 Leaves grow green. ");
        }

        public void GrowRoots()
        {
            Console.WriteLine("Tree 2 Grow Roots in the ground ");
        }
    }
}
