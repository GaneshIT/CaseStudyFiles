using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // This is the Base Component that defines operations that can be altered by decorators.
    public interface ICar
    {
        ICar ManufactureCar();
    }
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarWheels { get; set; }
        public string CarGlass { get; set; }
        public string Engine { get; set; }
        public override string ToString()
        {
            return "BMWCar [CarName=" + CarName + ", CarBody=" + CarBody + ", CarDoor=" + CarDoor + ", CarWheels="
                            + CarWheels + ", CarGlass=" + CarGlass + ", Engine=" + Engine + "]";
        }
        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels = "6 car glasses";
            CarGlass = "4 MRF wheels";
            return this;
        }
    }

    public class TataCar : ICar
    {
        private string CarName = "TATA";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarWheels { get; set; }
        public string CarGlass { get; set; }
        public string Engine { get; set; }
        public override string ToString()
        {
            return "BMWCar [CarName=" + CarName + ", CarBody=" + CarBody + ", CarDoor=" + CarDoor + ", CarWheels="
                            + CarWheels + ", CarGlass=" + CarGlass + ", Engine=" + Engine + "]";
        }
        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels = "6 car glasses";
            CarGlass = "4 MRF wheels";
            return this;
        }
    }

    //Inherited from the Base Component Interface
    public abstract class CarDecorator : ICar
    {
        //Create a Field to store the Concrete Component
        protected ICar car;
        //Initializing the Field using Constructor
        //While Creating an instance of the CarDecorator (Instance of the Child Class that Implements CarDecorator abstract)
        //We need to pass the existing car object which we want to decorate
        public CarDecorator(ICar car)
        {
            //Store that existing car object in the car variable
            this.car = car;
        }
        //Providing Implementation for the Base Component Interface
        //Here, we are just calling the Concrete Component ManufactureCar method
        //We are making this Method Virtual to allow the Child Concrete Decorator class to override
        public virtual ICar ManufactureCar()
        {
            //Call the Existing Car Object ManufactureCar method to return the car without engine
            //Later in the Child class of this abstract we will see how to call this method 
            //and how to add an Engine
            return car.ManufactureCar();//BMW, TATA
        }
    }

    //The following Concrete Decorator class will add Petrol Engine to the Existing Car
    class PetrolCarDecorator : CarDecorator
    {
        //Pass the existing car object while creating the Instance of PetrolCarDecorator class
        //Also pass the same existing pizza object to the base class constructor 
        //i.e. CarDecorator abstract class constructor
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }
        //Overriding the ManufactureCar method to add Petrol Engine
        public override ICar ManufactureCar()
        {
            //First Call the Concrete Components ManufactureCar Method 
            car.ManufactureCar();
            //Then Add a Petrol Engine by calling the AddEngine Method
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }

    class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}
