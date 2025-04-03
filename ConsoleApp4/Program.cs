﻿using ConsoleApp4;

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

//var 
//dynamic
