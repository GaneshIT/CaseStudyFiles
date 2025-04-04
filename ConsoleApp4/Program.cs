using ConsoleApp4;
using ConsoleApp4.BehavioralDesign;
using ConsoleApp4.StructureDesign;

#region demo

//int[] nums = { 2, 7, 11, 15 };
//int target = 9;
//int[] result = Class1.TwoSum(nums, target);
//Console.WriteLine($"[{result[0]}, {result[1]}]"); // Output: [0, 1]

//Console.WriteLine(Class1.IsValid("([{)]}")); // Output: True
//Console.WriteLine(Class1.IsValid("(]")); // Output: False
int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
int k = 4;
int n = arr.Length;
Console.WriteLine(Class1.maxSum(arr, n, k));


//int a = 10;
//int b = a;

//Customer silver = new SilverCustomer();
//Customer gold = new GoldCustomer();

//Client client = new Client();
//client.ShowDiscount(silver);
//client.ShowDiscount(gold);
////obj.Discount();

//IReport _excelReport = new ExcelDoc();
////Container<IReport,ExcelDoc>();
//IReport _wordReport = new WordDoc();
////Container<IReport, WordDoc>();
//Documents documents=new Documents(_wordReport);
//documents.Airtel();

#endregion

#region prototype
// Creating an Instance of Permanent Employee Class
//Employee emp1 = new PermanentEmployee()
//{
//    Name = "Anurag",
//    Department = "IT",
//    Type = "Permanent",
//    Salary = 100000
//};

////Creating a Clone of the above Permanent Employee
//Employee emp2 = emp1.GetClone();

//// Changing the Name and Department Property Value of emp2 instance, 
//// will not change the Name and Department Property Value of the emp1 instance
//emp2.Name = "Pranaya";
//emp2.Department = "HR";
//emp1.ShowDetails();
//emp2.ShowDetails();

//emp1.Name = "Raj";
//emp1.ShowDetails();
//emp2.ShowDetails();
//// Creating an Instance of Temporary Employee Class
//Employee emp3 = new TemporaryEmployee()
//{
//    Name = "Preety",
//    Department = "HR",
//    Type = "Temporary",
//    FixedAmount = 200000
//};

////Creating a Clone of the above Temporary Employee
//Employee emp4 = emp3.GetClone();

//// Changing the Name and Department Property Value of emp4 instance, 
//// will not change the Name and Department Property Value of the emp3 instance
//emp4.Name = "Priyanka";
//emp4.Department = "Sales";


//emp3.ShowDetails();
//emp4.ShowDetails();

//Console.Read();

#endregion

#region builder
// Constructing the PDF Report
// Step1: Create a Builder Object 
// Creating PDFReport Builder Object
PDFReport pdfReport = new PDFReport();

// Step2: Pass the Builder Object to the Director
// First Create an instance of ReportDirector
ReportDirector reportDirector = new ReportDirector();
// Then Pass the pdfReport Builder Object to the MakeReport Method of ReportDirector
// The ReportDirector will return one of the Representations of the Product
Report report = reportDirector.MakeReport(pdfReport);

// Step3: Display the Report by calling the DisplayReport method of the Product
report.DisplayReport();

Console.WriteLine("-------------------");
// Constructing the Excel Report
// The Process is going to be the same
ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();
#endregion

#region adapter
//Storing the Employees Data in a String Array
string[,] employeesArray = new string[5, 4]
{
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
};
//The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
Console.WriteLine("HR system passes employee string array to Adapter\n");
ITarget target = new EmployeeAdapter();
target.ProcessCompanySalary(employeesArray);
#endregion

#region bridge
// Except for the initialization phase, where an Abstraction object gets i.e. SonyRemoteControl or SamsungRemoteControl
// linked with a specific Implementation object i.e. new SonyLedTv() or new SamsungLedTv(), 
// the client code should only depend on the Abstraction class i.e. SonyRemoteControl or SamsungRemoteControl. 
AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
sonyRemoteControl.SwitchOn();
sonyRemoteControl.SetChannel(101);
sonyRemoteControl.SwitchOff();
Console.WriteLine();
AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
samsungRemoteControl.SwitchOn();
samsungRemoteControl.SetChannel(202);
samsungRemoteControl.SwitchOff();
#endregion

#region decorator
//Create an instance of Concrete Component BMWCar
ICar bmwCar1 = new BMWCar();
//Calling the ManufactureCar method will create the BMWCar without an engine
bmwCar1.ManufactureCar();
Console.WriteLine(bmwCar1 + "\n");
//Adding Diesel Engine to the bmwCar1
//Create an instance DieselCarDecorator class and 
//pass existing bmwCar1 as an argument to the Constructor which we want to decorate
DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
//Calling the ManufactureCar method on the carWithDieselEngine object will add Diesel Engine to the bmwCar1 car
carWithDieselEngine.ManufactureCar();
Console.WriteLine();
//The Process is the same for adding Petrol Engine to the existing Car
ICar bmwCar2 = new BMWCar();
PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
carWithPetrolEngine.ManufactureCar();
#endregion

#region proxy

Console.WriteLine("Client passing employee with Role Developer to folderproxy");
Empl emp1 = new Empl("Anurag", "Anurag123", "Developer");
SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
folderProxy1.PerformRWOperations();
Console.WriteLine();
Console.WriteLine("Client passing employee with Role Manager to folderproxy");
Empl emp2 = new Empl("Pranaya", "Pranaya123", "Manager");
SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
folderProxy2.PerformRWOperations();
#endregion

#region facade
//The Client will use the Facade Interface instead of the Subsystems
Order order = new Order();
order.PlaceOrder();
Console.Read();
#endregion

#region flyweight
//Creating Circle Objects with Red Color
Console.WriteLine("\n Red color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Red");
    circle.Draw();
}
//Creating Circle Objects with Green Color
Console.WriteLine("\n Green color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}
//Creating Circle Objects with Blue Color
Console.WriteLine("\n Blue color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}
//Creating Circle Objects with Orange Color
Console.WriteLine("\n Orange color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Orange");
    circle.Draw();
}
//Creating Circle Objects with Black Color
Console.WriteLine("\n Black color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Black");
    circle.Draw();
}
#endregion

#region chain
ATM atm = new ATM();
Console.WriteLine("Requested Amount 4600");
atm.Withdraw(4600);
Console.WriteLine("\nRequested Amount 1900");
atm.Withdraw(1900);
Console.WriteLine("\nRequested Amount 600");
atm.Withdraw(600);
Console.WriteLine("\nRequested Amount 750");
atm.Withdraw(750);
#endregion

#region command
//Create an Instance of Receiver
Document document = new Document();
//Create the Command Object by passing the Receiver Instance
ICommand openCommand = new OpenCommand(document);
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);
//Create the Invoker instance by passing the command objects
MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
//Giving command to the Invoker to do the operation
menu.ClickOpen();
menu.ClickSave();
menu.ClickClose();
#endregion

#region interpreter

//The following is going to be our Expression Tree
List<IExpression> objExpressions = new List<IExpression>();
//Creating the context object by passing the current date-time value
Context context = new Context(DateTime.Now);
//We want to Interpret the current date time as a specific format
//Ask the user to select the format
Console.WriteLine("Please Select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
context.Expression = Console.ReadLine();
//Split Expression which the user selects to an array so that we can apply different Expression rules
string[] strArray = context.Expression.Split(' ');
//Looping through Each Element of the Expression and adding the Appropriate Expression with the Expression Tree
foreach (var item in strArray)
{
    if (item == "DD")
    {
        objExpressions.Add(new DayExpression());
    }
    else if (item == "MM")
    {
        objExpressions.Add(new MonthExpression());
    }
    else if (item == "YYYY")
    {
        objExpressions.Add(new YearExpression());
    }
}
//Adding the SeparatorExpression
objExpressions.Add(new SeparatorExpression());
foreach (var obj in objExpressions)
{
    //Finally Evaluate Each Expression which is added in the Expression Tree
    obj.Evaluate(context);
}
//Print the Expression as Output
Console.WriteLine(context.Expression);
#endregion

#region Iterator
// Build a collection
ConcreteCollection collection = new ConcreteCollection();
collection.AddEmployee(new Elempoyee("Anurag", 100));
collection.AddEmployee(new Elempoyee("Pranaya", 101));
collection.AddEmployee(new Elempoyee("Santosh", 102));
collection.AddEmployee(new Elempoyee("Priyanka", 103));
collection.AddEmployee(new Elempoyee("Abinash", 104));
collection.AddEmployee(new Elempoyee("Preety", 105));

// Create iterator
Iterator iterator = collection.CreateIterator();
//looping iterator      
Console.WriteLine("Iterating over collection:");

for (Elempoyee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
}
#endregion

#region mediator
//Create an Instance of Mediator i.e. Creating a Facebook Group
IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
//Create instances of Colleague i.e. Creating users
User Ram = new ConcreteUser("Ram");
User Dave = new ConcreteUser("Dave");
User Smith = new ConcreteUser("Smith");
User Rajesh = new ConcreteUser("Rajesh");
User Sam = new ConcreteUser("Sam");
User Pam = new ConcreteUser("Pam");
User Anurag = new ConcreteUser("Anurag");
User John = new ConcreteUser("John");
//Registering the users with the Mediator i.e. Facebook Group
facebookMediator.RegisterUser(Ram);
facebookMediator.RegisterUser(Dave);
facebookMediator.RegisterUser(Smith);
facebookMediator.RegisterUser(Rajesh);
facebookMediator.RegisterUser(Sam);
facebookMediator.RegisterUser(Pam);
facebookMediator.RegisterUser(Anurag);
facebookMediator.RegisterUser(John);
//One of the users Sending one Message in the Facebook Group
Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
Console.WriteLine();
//Another user Sending another Message in the Facebook Group
Rajesh.Send("What is Design Patterns? Please explain ");
#endregion

#region memento
//Creating an Instance of the Originator and setting the current state as a 42-Inch Led TV
Originator originator = new Originator
{
    LedTV = new LEDTV("42-Inch", "60000", false)
};
//Storing the Internal State (Memento i.e. the Current Led TV) of the Originator in the Caretaker i.e. Store Room
//First, Create an instance of the Caretaker
Caretaker caretaker = new Caretaker();
//Second Create a snapshot or memento of the current internal state of the originator
Memento memento = originator.CreateMemento();
//Third, store the memento or snapshot in the store room i.e. Caretaker
caretaker.AddMemento(memento);
//Changing the Originator Current State to 46-Inch
originator.LedTV = new LEDTV("46-Inch", "80000", true);
//Again storing the Internal State (Memento) of the Originator in the Caretaker i.e. Store Room
//Create the memento or snapshot of the current internal state of the originator
memento = originator.CreateMemento();
//Store the memento in the Caretaker
caretaker.AddMemento(memento);
//Again, Changing the Originator Current State to 50-Inch
originator.LedTV = new LEDTV("50-Inch", "100000", true);
//The Current State of the Originator is now 50-Inch Led TV
Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());
//Restoring the Originator to one of its previous states
//We have added two Memento to the Caretaker
//Index-0 means the First memento i.e. 42 Inch LED TV
//Index-1 means the Second memento i.e. 46 Inch LED TV
Console.WriteLine("\nOriginator Restoring to 42-Inch LED TV");
originator.SetMemento(caretaker.GetMemento(0));
Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());

#endregion

#region observer
//Create a Product with Out of Stock Status
Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
//User Anurag will be created and the user1 object will be registered to the subject
Observer user1 = new Observer("Anurag");
user1.AddSubscriber(RedMI);
//User Pranaya will be created and the user1 object will be registered to the subject
Observer user2 = new Observer("Pranaya");
user2.AddSubscriber(RedMI);
//User Priyanka will be created and the user3 object will be registered to the subject
Observer user3 = new Observer("Priyanka");
user3.AddSubscriber(RedMI);
Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
Console.WriteLine();
user3.RemoveSubscriber(RedMI);
// Now the product is available
RedMI.SetAvailability("Available");
#endregion

#region state design
// Initially ATM Machine in DebitCardNotInsertedState
ATMMachine atmMachine = new ATMMachine();
Console.WriteLine("ATM Machine Current state : "
                + atmMachine.AtmMachineState.GetType().Name);
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.WithdrawMoney();
atmMachine.EjectDebitCard();
atmMachine.InsertDebitCard();
Console.WriteLine();
// Debit Card has been inserted so the internal state of the ATM Machine
// has been changed to DebitCardInsertedState
Console.WriteLine("ATM Machine Current state : "
                + atmMachine.AtmMachineState.GetType().Name);
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.WithdrawMoney();
atmMachine.InsertDebitCard();
atmMachine.EjectDebitCard();
Console.WriteLine("");
// Debit Card has been ejected so the internal state of the ATM Machine
// has been changed to DebitCardNotInsertedState
Console.WriteLine("ATM Machine Current state : "
                + atmMachine.AtmMachineState.GetType().Name);
#endregion

#region strategy design
// The client code picks a concrete strategy and passes it to the context. 
// The client should be aware of the differences between strategies in order to make the right choice.
//Create an instance of ZipCompression Strategy
ICompression strategy = new ZipCompression();
//Pass ZipCompression Strategy as an argument to the CompressionContext constructor
CompressionContext ctx = new CompressionContext(strategy);
ctx.CreateArchive("DotNetDesignPattern");
//Changing the Strategy using SetStrategy Method
ctx.SetStrategy(new RarCompression());
ctx.CreateArchive("DotNetDesignPattern");
#endregion

#region template
Console.WriteLine("Build a Concrete House\n");
HouseTemplate houseTemplate = new ConcreteHouse();
//Call the Template Method to Build the Concrete House
houseTemplate.BuildHouse();
Console.WriteLine();
Console.WriteLine("Build a Wooden House\n");
houseTemplate = new WoodenHouse();
//Call the Template Method to Build the Wooden House
houseTemplate.BuildHouse();

#endregion

#region vistor Design
//Create an instance of the object structure i.e. School class
School school = new School();
//Create an Instance of the Visitor i.e. Doctor
var visitor1 = new Doctor("James");
//Call the PerformOperation Method by passing the Visitor Object which wants to Visit
//All elements of the ObjectStructure i.e. a collection
//Here, Doctor James will Visit all the Kids at the School
school.PerformOperation(visitor1);
Console.WriteLine();
//Create an Instance of another Visitor i.e. Salesman
var visitor2 = new Salesman("John");
//Call the PerformOperation Method by passing the Visitor Object which wants to Visit
//All elements of the ObjectStructure i.e. a collection
//Here, the Salesman John will Visit all the Kids of the School
school.PerformOperation(visitor2);
#endregion


/*
 * interface IFlight{
 * }
 * Class 708:IFlight{
 * }
 * Class 812:IFlight{
 * }
 * Class 815:IFlight{
 * }
 * Interface IMediator{
 *  
 * }
 * class Mediator:IMediator{
 *  public Mediator(IFlight flightInstace){
 *  
 *  }
 * }
 * 
 * update table
 * 
 * begin tran
 * insert into table();
 * update table
 * commit
 * rollback
 * end 
 */