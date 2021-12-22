using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp
{
    class Tree
    {
        //HAVING AUTOS -> 12(attributes)  are not required
        //private int NrOfLeaves;
        //explicit atributes age 26-29 with Property A
        private int age;

        public Tree(int NrOfLeaves, int Age)
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
    }
}
