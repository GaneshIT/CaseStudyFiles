using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.BehavioralDesign
{
    public abstract class HouseTemplate
    {
        // Template Method defines the sequence for building a house
        public void BuildHouse()
        {
            //Define the Steps to Build a House
            BuildFoundation(); //Step1
            BuildPillars(); //Step2
            BuildWalls(); //Step3
            BuildWindows(); //Step4
            Console.WriteLine("House is Built");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }

    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Concrete Pillars with Cement and Sand");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Concrete Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Concrete Windows");
        }
    }

    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods, wood and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine("Building wood Pillars with wood coating");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wood Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wood Windows");
        }
    }
}
