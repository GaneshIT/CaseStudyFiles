using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.StructureDesign
{
    // Collection Item
    class Elempoyee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Elempoyee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }

    // ConcreteIterator Class
    class Iterator : IAbstractIterator
    {
        //ConcreteAggregate variable to hold the collection elements
        private ConcreteCollection Collection;
        //The following variable is used as the Index Position 
        //to access the elements of the collection
        private int Current = 0;
        //The following variable is used to move to the next element from the current element
        private readonly int Step = 1;
        // Constructor
        public Iterator(ConcreteCollection Collection)
        {
            //Initializing the ConcreteAggregate variable using Constructor
            this.Collection = Collection;//XML, Tree, Dict, etc
        }
        // Gets First Item from the Collection
        public Elempoyee First()
        {
            //Setting Current as 0 to access the First Element of the Sequence
            Current = 0;
            return Collection.GetEmployee(Current);
        }
        // Gets Next Item from the Collection
        public Elempoyee Next()
        {
            //Increase the Current Index Position by step (Step = 1), 
            //to access the Next Element from the collection
            Current += Step;
            if (!IsCompleted)
            {
                return Collection.GetEmployee(Current);
            }
            else
            {
                return null;
            }
        }
        // Check whether the iteration is complete
        public bool IsCompleted
        {
            //When Current >= Collection.Count, means we have accessed all the elements
            get { return Current >= Collection.Count; }
        }
    }

    // Aggregate Interface
    interface IAbstractCollection
    {
        // The following Method is going to Return an Iterator object.
        // Later, we will Implement the Iterator class
        Iterator CreateIterator();
    }

    // ConcreteAggregate Class
    // The following class going to implement the Iterator interface to return an instance of the proper ConcreteIterator
    class ConcreteCollection : IAbstractCollection
    {
        //The following collection object is going to hold a list of items or elements
        private List<Elempoyee> listEmployees = new List<Elempoyee>();
        //Implementing the CreateIterator method of the IAbstractCollection interface
        //The following method is going to Create and return the Iterator Object
        //Later we will implement the Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // The following method is going to return the count of the elements present in the collection
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Elempoyee employee)
        {
            listEmployees.Add(employee);
        }
        //Get items from the collection based on the Index Position
        //Index is started from 0
        public Elempoyee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }

    // Iterator Interface
    // This is going to be an interface defining the operations for accessing and traversing elements in a sequence.
    interface IAbstractIterator
    {
        Elempoyee First();
        Elempoyee Next();
        bool IsCompleted { get; }
    }
}
