using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.StructureDesign
{
    //Step 1: Creating LED TV

    //This is the Model class that is going to hold the Product information i.e. Led TV Details
    public class LEDTV
    {
        //Properties of the LED TV
        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }
        //Initializing the Properties using Constructor
        public LEDTV(string Size, string Price, bool USBSupport)
        {
            this.Size = Size;
            this.Price = Price;
            this.USBSupport = USBSupport;
        }
        //Fetching the Details of the LedTV
        public string GetDetails()
        {
            return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + "]";
        }
    }

    //Step 2: Creating Memento
    //This is going to be a class that holds the information
    //about the Originator’s saved state.
    //Stores the internal state of the Originator object.
    public class Memento
    {
        //The following Variable is going to Hold the Internal State of the Originator object
        public LEDTV LedTV { get; set; }
        //Initializing the Internal State of Originator Object using Constructor
        public Memento(LEDTV ledTV)
        {
            LedTV = ledTV;
        }
        //This Method is going to return the Internal State of the Originator
        public string GetDetails()
        {
            return "Memento [LedTV=" + LedTV.GetDetails() + "]";
        }
    }

    //Step 3: Creating Caretaker
    //This is going to be a class that is used to
    //hold a Memento object for later use.
    //This acts as a store only; it never Checks or
    //Modifies the contents of the Memento object.
    public class Caretaker
    {
        //This variable is going to hold the List of Mementos that are used by the Originator.
        private List<Memento> LedTvList = new List<Memento>();
        //This Method will add the memento i.e. the internal state of the Originator into the Caretaker i.e. Store Room 
        public void AddMemento(Memento m)
        {
            LedTvList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }
        //This Method is used to return one of the Previous Originator Internal States which saved in the Caretaker
        public Memento GetMemento(int index)
        {
            return LedTvList[index];
        }
    }

    //Step 4: Creating Originator
    //This is going to be a class that creates a memento object containing a snapshot of the Originator's current state. 
    //It also restores the Originator to a previously stored state.
    public class Originator
    {
        //This Property is used to store the current state of the Originator
        public LEDTV LedTV;
        //It will Create a snapshot of the current state of the Originator i.e. Current LedTV 
        //and return that Memento which we can store in the Caretaker i.e. in the Store Room
        public Memento CreateMemento()
        {
            return new Memento(LedTV);
        }
        //This Method is going to change the Internal State of the Originator to one of its Previous State
        public void SetMemento(Memento memento)
        {
            LedTV = memento.LedTV;
        }
        //This Method is going to return the Details of the Current Internal State of the Originator
        public string GetDetails()
        {
            //To Fetch the Details, internally it is calling the GetDetails method on LedTV Object
            return "Originator [LEDTV=" + LedTV.GetDetails() + "]";
        }
    }


}
