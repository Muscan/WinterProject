using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise2
{
    class Forest
    {
        //public List<Tree> treeList; //public attribute changed to public property(line 18)
        public Forest()
        {
            Console.WriteLine("I`m constructor for the List");
            //treeList = new List<Tree>();
            TreeList = new List<Tree>();
        }
        public List<Tree> TreeList { get; set; }

        public void PrintAllInstanceHeight()
        {
            Console.WriteLine("Nr of leaves, age, Instance Height");
            foreach (Tree saveTreeHere in TreeList)
            {
                Console.WriteLine(saveTreeHere.NrOfLeaves + " " + saveTreeHere.Age + " " + saveTreeHere.InstanceHeight);
            }
        }

        public void PrintAllStaticHeight()
        {
            Console.WriteLine("Nr of leaves, age, Static Height");
            foreach (Tree saveTreeHere in TreeList)
            {

                Console.WriteLine(saveTreeHere.NrOfLeaves + " " + saveTreeHere.Age + " " + Tree.StaticHeight);
            }
        }
    }
}
