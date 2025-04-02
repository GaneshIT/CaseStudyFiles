using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //The Prototype Abstract Class
    //This is an abstract class which is used for the types of object that can be cloned itself.
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }

        public abstract Employee GetClone();
        public abstract void ShowDetails();
    }

    //This is a class that implements the Prototype interface for cloning itself.
    public class PermanentEmployee : Employee
    {
        public int Salary { get; set; }
        public override Employee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            // So typecast the Object Appropriate Type
            // In this case, typecast to PermanentEmployee type
            return (PermanentEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Salary: {this.Salary}\n");
        }
    }

    //This is a class that implements the Prototype interface for cloning itself.
    public class TemporaryEmployee : Employee
    {
        public int FixedAmount { get; set; }
        public override Employee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            // So typecast the Object Appropriate Type
            // In this case, typecast to TemporaryEmployee type
            return (TemporaryEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Temporary Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }
    }


}
