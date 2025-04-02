using ConsoleApp4;

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
//// Constructing the PDF Report
//// Step1: Create a Builder Object 
//// Creating PDFReport Builder Object
//PDFReport pdfReport = new PDFReport();

//// Step2: Pass the Builder Object to the Director
//// First Create an instance of ReportDirector
//ReportDirector reportDirector = new ReportDirector();
//// Then Pass the pdfReport Builder Object to the MakeReport Method of ReportDirector
//// The ReportDirector will return one of the Representations of the Product
//Report report = reportDirector.MakeReport(pdfReport);

//// Step3: Display the Report by calling the DisplayReport method of the Product
//report.DisplayReport();

//Console.WriteLine("-------------------");
//// Constructing the Excel Report
//// The Process is going to be the same
//ExcelReport excelReport = new ExcelReport();
//report = reportDirector.MakeReport(excelReport);
//report.DisplayReport();
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


int a = 10;
object b = a;

string c = b;