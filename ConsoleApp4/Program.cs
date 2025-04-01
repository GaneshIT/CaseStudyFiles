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


int a = 10;
int b = a;

Customer silver = new SilverCustomer();
Customer gold = new GoldCustomer();

Client client = new Client();
client.ShowDiscount(silver);
client.ShowDiscount(gold);
//obj.Discount();

IReport _excelReport = new ExcelDoc();
//Container<IReport,ExcelDoc>();
IReport _wordReport = new WordDoc();
//Container<IReport, WordDoc>();
Documents documents=new Documents(_wordReport);
documents.Airtel();

