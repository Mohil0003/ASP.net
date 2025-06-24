// Program 1
//Console.WriteLine("Name : Mohil Parmar");
//Console.WriteLine("Address : Rajkot");
//Console.WriteLine("Number : 1234567890");
//Console.WriteLine("City : Rajkot");
//-----------------------------------------------------------------------------------------------------

// Program 2
//Console.Write("Enter first number : ");
//int n1 = int.Parse(Console.ReadLine());
//Console.Write("Enter second number : ");
//int n2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Number 1 : " +  n1);
//Console.WriteLine("Number 2 : " +  n2); 
//-----------------------------------------------------------------------------------------------------

// Program 3
//Console.Write("Enter your name : ");
//string name = Console.ReadLine();
//Console.Write("Enter your country name : ");
//string country = Console.ReadLine();
//Console.WriteLine($"Hello {name} from country {country}");
//-----------------------------------------------------------------------------------------------------

// Program 4
//Console.Write("Enter length in feet : ");
//double length = double.Parse(Console.ReadLine());
//Console.Write("Enter width in feet : ");
//double width = double.Parse(Console.ReadLine());
//double area = length *  width;
//Console.WriteLine("Area in sd ft : " + area);
//-----------------------------------------------------------------------------------------------------

// Program 5
//Console.Write("Enter length of square : ");
//double length = double.Parse(Console.ReadLine());
//Console.WriteLine("Area of square : " + length * length);

//Console.Write("Enter length of rectangle : ");
//double len = double.Parse(Console.ReadLine());
//Console.Write("Enter length of rectangle : ");
//double width = double.Parse(Console.ReadLine());
//Console.WriteLine("Area of rectangle : " + len * width);

//Console.Write("Enter redious of circle : ");
//double redious = double.Parse(Console.ReadLine());
//Console.WriteLine("Area of circle : " + 2 * 3.14 * redious);
//-----------------------------------------------------------------------------------------------------

// Program 6
//Console.Write("Enter temperature in celcius : ");
//double c = double.Parse(Console.ReadLine());
//Console.WriteLine("Temperature in farenheit : " +  CelciusToFarenheit(c));

//Console.Write("Enter temperature in farenheit : ");
//double f = double.Parse(Console.ReadLine());
//Console.WriteLine("Temperature in celcius : " + FarenheitToCelcius(f));

//static double CelciusToFarenheit(double c)
//{
//    return (9 / 5 * c) + 32;
//}

//static double FarenheitToCelcius(double f)
//{
//    return (f - 32) * 5 / 9;
//}
//-----------------------------------------------------------------------------------------------------

// Program 7
//Console.Write("Enter Principal: ");
//double principal = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter Rate of Interest: ");
//double rate = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter Time (in years): ");
//double time = Convert.ToDouble(Console.ReadLine());

//double simpleInterest = CalculateSimpleInterest(principal, rate, time);

//static double CalculateSimpleInterest(double principal, double rate, double time)
//{
//    return (principal * rate * time) / 100;
//}
//--------------------------------------------------------------------------

// Program 8

// 1) Using if-else
//Console.Write("Enter first number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter operator (+, -, *, /): ");
//char op = Convert.ToChar(Console.ReadLine());

//Console.Write("Enter second number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//double ans;

//if (op == '+')
//    ans = num1 + num2;
//else if (op == '-')
//    ans = num1 - num2;
//else if (op == '*')
//    ans = num1 * num2;
//else if (op == '/')
//{
//    if (num2 == 0)
//    {
//        Console.WriteLine("Cannot divide by zero.");
//        return;
//    }
//    else
//    {
//        ans = num1 / num2;
//    }
//}
//else
//{
//    Console.WriteLine("Invalid operator.");
//    return;
//}
//Console.WriteLine($"{num1} {op} {num2} = {ans}");

// ==================================================================
// 2) Using swich-case 
//Console.Write("Enter first number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter operator (+, -, *, /): ");
//char op = Convert.ToChar(Console.ReadLine());

//Console.Write("Enter second number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//double ans = 0;

//switch (op)
//{
//    case '+':
//        ans = num1 + num2;
//        Console.WriteLine("Result: " + ans);
//        break;

//    case '-':
//        ans = num1 - num2;
//        Console.WriteLine("Result: " + ans);
//        break;

//    case '*':
//        ans = num1 * num2;
//        Console.WriteLine("Result: " + ans);
//        break;

//    case '/':
//        if (num2 != 0)
//        {
//            ans = num1 / num2;
//            Console.WriteLine("Result: " + ans);
//        }
//        else
//        {
//            Console.WriteLine("Cannot divide by zero.");
//        }
//        break;

//    default:
//        Console.WriteLine("Invalid operator.");
//        return;

//}
//Console.WriteLine($"{num1} {op} {num2} = {ans}");


// Program 9
//Console.Write("Enter first number: ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number: ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Before swap num1 & num2 : {n1} & {n2}");
//n1 = n1 + n2;
//n2 = n1 - n2;
//n1 = n1 - n2;
//Console.WriteLine($"After  swap num1 & num2 : {n1} & {n2}");


// Program 10
//Console.Write("Enter first number: ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number: ");
//int n2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter third number: ");
//int n3 = Convert.ToInt32(Console.ReadLine());

//int largest = (n1 > n2) ? ((n1 > n3) ? n1 : n3) : ((n2 > n3) ? n2 : n3);
//Console.WriteLine($"{largest} is largest");





//using Lab_Project.Lab_2;

//Candidate obj = new Candidate();
//obj.GetCandidateDetails();
//obj.DisplayCandidateDetails();




//using Lab_Project.Lab_2;
//Staff[] obj = new Staff[5];
//for(int i = 0; i<5; i++)
//{
//    Console.WriteLine("===============================");
//    obj[i] = new Staff();
//    obj[i].GetDetails();
//}

//Console.WriteLine("////////////////////////////////");

//Console.WriteLine("Names of HOD Deparment : ");
//for(int i = 0; i<5; i++)
//{
//    obj[i].DisplayStaff();
//}




//using Lab_Project.Lab_2;

//Bank_Account B1 = new Bank_Account();
//B1.GetAccountDetails();
//Console.WriteLine("====================");
//B1.DisplayAccountDetails();




//using Lab_Project.Lab_2;

//Student obj = new Student("23010101192","mohil",8.6,8.5);
//obj.DisplayStudentDetails();



//using Lab_Project.Lab_2;
//RectangleArea obj = new RectangleArea(10,20);




//using Lab_Project.Lab_2;
//Console.WriteLine("Enter Basic Salary : ");
//int basic = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter TA Salary : ");
//int ta = Convert.ToInt32(Console.ReadLine());

//Salary obj = new Salary(basic , ta , 30000 , 500000);



//using Lab_Project.Lab_2;
//Console.WriteLine("Enter Distance 1 : ");
//int dist1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Distance 2 : ");
//int dist2 = Convert.ToInt32(Console.ReadLine());
//Distance obj = new Distance(dist1 , dist2);
//obj.Addition_Dist();
//obj.Display();



using Lab_Project.Lab_2;

Console.WriteLine("Enter Material Type : ");
string Material = Console.ReadLine();
Console.WriteLine("Enter Price : ");
int Price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Height : ");
int Height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Surface Area : ");
int Area = Convert.ToInt32(Console.ReadLine());

Table obj = new Table( Height , Area, Material, Price);