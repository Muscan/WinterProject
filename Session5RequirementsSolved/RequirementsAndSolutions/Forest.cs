using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5RequirementsSolved.RequirementsAndSolutions
{
    //Exercise 1
    partial class Forest
    {
        //public List<Tree> treeList; //public attribute changed to public property(line 18)
        public Forest()
        {
            Console.WriteLine("I`m constructor for the List");
            //treeList = new List<Tree>();
            TreeList = new List<Tree>();
        }
        public List<Tree> TreeList { get; set; }
        //using public partial class Forest, males TreeList not accessible


        public void PrintAllStaticHeight()
        {
            Console.WriteLine("Nr of leaves, age, Static Height");
            foreach (Tree saveTreeHere in TreeList)
            {

                Console.WriteLine(saveTreeHere.NrOfLeaves + " " + saveTreeHere.Age + " " + Tree.StaticHeight);
            }
        }
    }

    partial class Forest
    {
        public void PrintAllInstanceHeight()
        {
            Console.WriteLine("Nr of leaves, age, Instance Height");
            foreach (Tree saveTreeHere in TreeList)
            {
                Console.WriteLine(saveTreeHere.NrOfLeaves + " " + saveTreeHere.Age + " " + saveTreeHere.InstanceHeight);
            }
        }
    }
}
