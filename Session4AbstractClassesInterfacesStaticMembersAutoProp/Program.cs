using Session4AbstractClassesInterfacesStaticMembersAutoProp.Exercise2;
using System;

namespace Session4AbstractClassesInterfacesStaticMembersAutoProp
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            string printAge = "Nr of years: ";
            string printLeaves = "Nr. of leaves: ";
            Tree stejar = new Tree(1732, 17);
            Tree fag = new Tree(7900, 79);
            stejar.NrOfLeaves = 1000;
            Console.WriteLine(printLeaves + stejar.NrOfLeaves);
            fag.Age = 7;
            Console.WriteLine(printAge + fag.Age);

            //exercise2
            Forest forest = new Forest();
            // forest.treeList.Add(stejar);
            forest.TreeList.Add(stejar);
            //forest.treeList.Add(fag);
            forest.TreeList.Add(fag);
            for (int i = 0; i < 100; i++)
            {
                Tree tree = new Tree(i + 1000, i + 100);
                //forest.treeList.Add(tree);
                forest.TreeList.Add(tree);

            }
            //Console.WriteLine("Nr of trees: " + forest.treeList.Count);
            Console.WriteLine("Nr of trees: " + forest.TreeList.Count);
            //Remove first tree
            //forest.treeList.RemoveAt(0);
            forest.TreeList.RemoveAt(0);
            //insert at pos 0
            Tree plop = new Tree(377, 111);
            //forest.treeList.Insert(0,plop);
            forest.TreeList.Insert(0, plop);
            //Console.WriteLine(printLeaves+ " plop " + forest.treeList[0].NrOfLeaves);
            Console.WriteLine(printLeaves + " plop " + forest.TreeList[0].NrOfLeaves);
            //Exercise 3 part 1
            //
            //for 50 years

            //for each tree in the list

            //increase the tree's InstanceHeight by 50cm

            //for each tree in the list

            //set its InstanceHeight to zero
            //instance property only means you can change it anytime at any Instance

            Forest forest2 = new Forest();
            for (int i = 0; i < 50; i++)
            {
                Tree tree = new Tree(i + 1000, i + 100);
                tree.InstanceHeight = 0;
                forest2.TreeList.Add(tree);

            }
            forest2.PrintAllInstanceHeight();

            for (int i = 0; i < 50; i++)
            {
                foreach (Tree tree in forest2.TreeList)
                {
                    tree.InstanceHeight += 50;

                }
            }

            foreach (Tree tree in forest2.TreeList)
            {
                tree.InstanceHeight = 0;
            }
            // Am terminat aici cu instanceHeight
            //----------------------------------------
            //Using the static property only:
            //Create 50 trees
            Forest forestStatic = new Forest();
            Tree.StaticHeight = 0;
            for (int i = 0; i < 50; i++)
            {
                Tree tree = new Tree(i + 1000, i + 100);
                forestStatic.TreeList.Add(tree);
            }
            forestStatic.PrintAllStaticHeight();


            for (int i = 0; i < 50; i++)
            {
                //increase the trees' StaticHeight by 50 cm
                Tree.StaticHeight += 50;
            }
            Tree.StaticHeight = 0;
            //For changing static, only Class.Property is needed

            /*Membrii statici sunt tinuti la nivel de clasa
                Un membru care se aplica pe instantele clasei respective. 
                Se acceseaza folosind numele unei clase.
                Cele non statice se acceeeaza prin numele obiectului
                - Putem avea si metode statice
                - Daca declar o clasa statica, tot ce este in interiorul ei, trebuie sa fie static
                O metoda non statica poate fi apleata intr-o metoda statica
                Nu ne trebuie o instanta a unui obiect ca sa folosim membrii statici
                - Abstracta - obligam toate clasele care mostenesc clasa noastra de baza sa o implementez. 
                - Interfete -> Modalitatea prin care interactioneaza si sistemele pot fii aplicatii diferite/acelasi program.
                Definesc o structura. 
                Exista interfete la nivel de cod. 
                O interfata este implementata
                O clasa este mostenita. 
                Orice interfacta trebuia sa inceapa cu I
                Spre deosebire de o clasa abstracta, nu putem avea si implmentare
                Nu putem avea fieds
                Sunt folositoare pentru conectari la baza de date. 
                Putem folosi Interfete sa ne conectam la db, fara sa stim care e conectorul*/
        }
    }
}
