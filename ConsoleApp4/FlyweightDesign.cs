﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // Flyweight Interface
    // This is an interface that defines the members of the flyweight objects.
    public interface IShape
    {
        void Draw();
    }
    // ConcreteFlyweight
    // This is a class which is Inherits from the Flyweight Interface.
    public class Circle : IShape
    {
        public string Color { get; set; }
        //The following Properties Values are going to be the same for all Circle Shape Object
        private readonly int XCor = 10;
        private readonly int YCor = 20;
        private readonly int Radius = 30;
        //For Each Circle Object, we need to call the Following Method to set the Color
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + XCor + ", YCor :" + YCor + ", Radius :" + Radius);
        }
    }

    // FlyweightFacory
    // This is a factory class used to create concrete objects of the ConcreteFlyweight type
    public class ShapeFactory
    {
        //The Following Dictionary is going to act as our Cache Memory
        private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();
        //The following Method is going to return the Shape Object
        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                //If the key shapeType i.e. circle is stored in the Cache, then return the value of the key
                //else create circle object, store it in the Cache, and return the object
                if (shapeMap.TryGetValue("circle", out shape))
                {
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape);
                    Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
                }
            }
            return shape;
        }
    }
}
