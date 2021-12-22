using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp
{
    class Requirements
	{/*
      /*Homework Session 6

		Exercise 1. Properties
		Create a class Tree with a NrOfLeaves property of type int,->done
		implemented as an auto property (without an explicit backing field). -> done
		Also create a property named Age, with a backing field. ->done
		In the Main method, create multiple instances of the Tree class, and set the values for their properties.->done 
		Check what happens with the objects' properties values in debug mode. -> start with null then assign values
		Change the Age property's setter to private, and explain what happens with the existing program. -> the property cannot
		be
		accessed from outside the class/setted
		
		Exercise 2. List
		Create a new class named Forest which contains a list of trees (List<Tree>) as a public member. ->done
		In method Main create on object of type forest and populate the list of trees with multiple trees. ->done
		Try to find multiple ways of populating the trees list. 
		Find the suitable methods on the List for removing/inserting/counting/etc trees in the list of trees.->done 
		Change the list of trees from a public member to a public property,-> attributes are not used.Properpry instead(insteed of nrOfTrees -> NrOfTrees)
		
		and make the necessary changes for the program to compile and execute successfully.->done 
		
		Exercise 3. Instance memebers vs static members
		Create a program which plants 50 trees, grows them for 50 years (by 50 cm each year), 
		and then cuts them all (sets the height to zero),
		using first an instance-based approach and then a static-based approach. 
		For this, use the Tree class defined previously and add an int InstanceHeight property, 
		and a static int StaticHeight property. 
		Create a list of 50 trees in main, then something like:
			1. Using the instance property only:
		
			for 50 years
				for each tree in the list	
					increase the tree's InstanceHeight by 50cm
					
			for each tree in the list
				set its InstanceHeight to zero
				
			2. Using the static property only:
			for 50 years
				increase the trees' StaticHeight by 50 cm
		
			set the trees' StaticHeight to 0
		
		Exercise 4: Abstract classes
		Let's modify the Tree class by adding an abstract method public abstract bool LeavesAreFalling(), 
		which is a methods which returns a boolean value telling us if the tree is a falling leaves tree or not.
		We'll leave it abstract because we know for sure that all trees are either falling leaves trees or non-falling leaves trees. 
		Then let's create two more classes, Oak (stejar) and Fir (brad), and make them implement the Tree class. 
		Implement the LeavesAreFalling method accordingly in both classes.
		
		Exercise 5: Interfaces
		Declare an interface IGrowingRootsTree with a method void GrowRoots(). 
		Declare an interface IFallingLeavesTree with two methods: void LeavesFall() and void LeavesGrow(). 
		Since all trees are growing roots, but only some of them have falling leaves, 
		please implement these two new interfaces in the previously defined classes structure Oak/Fir/Tree. 
		Note that a class can implement multiple interfaces. 
		Bonus: define a new class named HybridTree, which should be a mix of an oak and a fir,
		so try to make the HybridTree class inherit both classes Oak and Fir. Observe and explain what happens and why.*/
    }
}
